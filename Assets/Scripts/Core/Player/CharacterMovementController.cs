using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private GameObject _lookRotation;
    [SerializeField] private int _boostTime;
    [SerializeField] private float _speedBoost;
    [SerializeField] private float _jumpBoost;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _gravity;

    private Rigidbody _rigidbody;
    private JumpPermission _jumpPremission;

    void Start()
    {
        Physics.gravity = -Vector3.up * _gravity;
        _jumpPremission = GetComponentInChildren<JumpPermission>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_jumpPremission.Permission)
        {
            float _x = Input.GetAxis("Vertical");
            float _z = Input.GetAxis("Horizontal");
            float _y = _rigidbody.velocity.y;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _y = _jumpForce;
            }

            Vector3 _velocityXZ = _lookRotation.transform.forward * _x + _lookRotation.transform.up * _rigidbody.velocity.y + _lookRotation.transform.right * _z;
            if (_x > 0.1f || _x < -0.1f || _z > 0.1f || _z < -0.1f)
            {
                _rigidbody.velocity = _velocityXZ * _speed;
            }

            Vector3 _velocityY = new Vector3(_rigidbody.velocity.x , _y, _rigidbody.velocity.z);
            if (_y > 0.1f || _y < -0.1f) _rigidbody.velocity = _velocityY;
        }
    }

    public void LaunchSpeedBoost(GameObject can)
    {
        can.SetActive(false);
        StartCoroutine(SpeedBoost(can));
    }

    private IEnumerator SpeedBoost(GameObject can)
    {
        float _deafultSpeed = _speed;
        float _deafultJump = _jumpForce;


        while (Camera.main.fieldOfView < 79)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 80, 0.1f);
            yield return new WaitForSeconds(0.01f);
        }

        _speed *= _speedBoost;
        _jumpForce *= _jumpBoost;

        yield return new WaitForSeconds(_boostTime);

        can.SetActive(true);

        while (Camera.main.fieldOfView > 61)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60, 0.1f);
            yield return new WaitForSeconds(0.01f);
        }


        _speed = _deafultSpeed;
        _jumpForce = _deafultJump;
    }
}

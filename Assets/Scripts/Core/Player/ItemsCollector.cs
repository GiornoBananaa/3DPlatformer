using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemsCollector : MonoBehaviour
{
    [SerializeField] private int _sprayLayer;
    [SerializeField] private int _keyLayer;
    [SerializeField] private Animator _doorAnimator;

    private CharacterMovementController _characterMovement;

    private void Start()
    {
        _characterMovement = GetComponentInParent<CharacterMovementController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _sprayLayer)
        {
            _characterMovement.LaunchSpeedBoost(other.gameObject);
        }
        else if (other.gameObject.layer == _keyLayer)
        {
            Destroy(other.gameObject);
            _doorAnimator.SetTrigger("Open");
        }
    }
}

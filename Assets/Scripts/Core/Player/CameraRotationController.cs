using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationController : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity;
    [SerializeField] private GameObject _character;

    private float _x;
    private float _y;
    private float _mouseY;

    void Update()
    {
        _x += Input.GetAxis("Mouse X");

        _mouseY = -Input.GetAxis("Mouse Y");
        if (_y + _mouseY < 80 && _y + _mouseY > -80) _y += _mouseY;

        transform.localRotation = Quaternion.Euler(_y, _x, 0);

        transform.position = _character.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceTrigger : MonoBehaviour
{
    [SerializeField] private Transform _point;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody _rigidbody;
        if (_rigidbody = other.GetComponent<Rigidbody>())
        {
            _rigidbody.velocity = _point.localPosition;
            _rigidbody.angularVelocity = -_point.localPosition.x * Vector3.forward;
        }
    }
}

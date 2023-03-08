using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookRotation : MonoBehaviour
{
    [SerializeField] private Transform _cameraRotation;

    void Update()
    {
        transform.rotation = new Quaternion( 0, _cameraRotation.rotation.y, 0, _cameraRotation.rotation.w);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPermission : MonoBehaviour
{
    private bool _permission;
    private int _count;

    private void Start()
    {
        _permission = true;
    }

    private void Update()
    {
        transform.rotation = Quaternion.identity;
    }

    public bool Permission
    {
        get => _permission;
    }

    private void OnTriggerEnter(Collider other)
    {
        _permission = true;

        _count++;
    }

    private void OnTriggerExit(Collider other)
    {
        _count--;
        if (_count == 0) _permission = false;
    }
}

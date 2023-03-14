using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawn;

    private static Transform _checkpoint;


    private void Start()
    {
        _checkpoint = _playerSpawn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovementController>())
        {
            _checkpoint.position = transform.position;
        }
    }

    public static Vector3 CheckPoint
    {
        get => _checkpoint.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Transform _playerSpawn;

    private void Start()
    {
        _playerSpawn = GetComponentInChildren<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterMovementController>())
        {
            other.gameObject.transform.position = _playerSpawn.position;
        }
        //if (other.gameObject.GetComponent<ImportantObject>()) { }
    }
}

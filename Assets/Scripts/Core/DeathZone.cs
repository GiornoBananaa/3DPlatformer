using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterMovementController>())
        {
            Debug.Log(_playerSpawn.name);
            other.gameObject.transform.position = _playerSpawn.position;
        }
        //if (other.gameObject.GetComponent<ImportantObject>()) { }
    }
}

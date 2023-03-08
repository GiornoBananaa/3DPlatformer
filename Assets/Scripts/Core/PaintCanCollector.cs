using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintCanCollector : MonoBehaviour
{
    [SerializeField] private int _sprayLayer;

    private CharacterMovementController _characterMovement;

    private void Start()
    {
        _characterMovement = GetComponentInParent<CharacterMovementController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _sprayLayer)
        {
            Destroy(other.gameObject);
            _characterMovement.LaunchSpeedBoost();
        }
    }
}

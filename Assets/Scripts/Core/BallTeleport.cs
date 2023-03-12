using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTeleport : MonoBehaviour
{
    [SerializeField] private Transform _teleportPosition;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = _teleportPosition.position;
    }
}

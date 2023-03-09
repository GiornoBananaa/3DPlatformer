using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsHintOffTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _controlsHint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovementController>())
        {
            _controlsHint.SetActive(false);
        }
    }
}

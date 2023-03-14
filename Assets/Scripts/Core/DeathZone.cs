using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterMovementController>())
        {
            other.gameObject.transform.position = CheckPointTrigger.CheckPoint;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (other.gameObject.GetComponent<ImportantObject>()) 
        {
            other.gameObject.transform.localPosition = Vector3.zero;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}

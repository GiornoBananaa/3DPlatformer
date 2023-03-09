using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeButton : MonoBehaviour
{
    [SerializeField] private Animator _bridgeAnimator;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<ImportantObject>())
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            _bridgeAnimator.SetTrigger("Down");
        }
    }
}

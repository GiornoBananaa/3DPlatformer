using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColoringTouch : MonoBehaviour
{
    [SerializeField] private int _levelLayer;

    private List<GameObject> _coloredObjects;

    private void Start()
    {
        _coloredObjects = new List<GameObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject _object = collision.collider.gameObject;

        if (_object.layer == _levelLayer)
        {
            if(_coloredObjects.Count != 0)
            {
                if(_object != _coloredObjects[_coloredObjects.Count - 1])
                {
                    _object.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0,1,0.9f,1,0.8f,1);
                    _coloredObjects.Add(_object);
                }
            }
            else
            {
                _object.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1, 0.9f, 1, 0.8f, 1);
                _coloredObjects.Add(_object);
            }
        }
    }
}

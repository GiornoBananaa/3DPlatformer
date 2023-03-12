using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemsCollector : MonoBehaviour
{
    [SerializeField] private int _sprayLayer;
    [SerializeField] private int _keyLayer;
    [SerializeField] private Animator _doorAnimator;
    [SerializeField] private AudioClip _keySound;
    [SerializeField] private AudioClip _boostSound;

    private AudioSource _audio;
    private CharacterMovementController _characterMovement;

    private void Start()
    {
        _audio = GetComponentInParent<AudioSource>();
        _characterMovement = GetComponentInParent<CharacterMovementController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _sprayLayer)
        {
            _characterMovement.LaunchSpeedBoost(other.gameObject);
            _audio.clip = _boostSound;
            _audio.Play();
        }
        else if (other.gameObject.layer == _keyLayer)
        {
            Destroy(other.gameObject);
            _doorAnimator.SetTrigger("Open");
            _audio.clip = _keySound;
            _audio.Play();
        }
    }
}

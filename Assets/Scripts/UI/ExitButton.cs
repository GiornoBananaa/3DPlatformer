using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        _exitButton.onClick.AddListener( () => Application.Quit());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        _mainMenuButton.onClick.AddListener(() => SceneManager.LoadScene(0));
    }
}

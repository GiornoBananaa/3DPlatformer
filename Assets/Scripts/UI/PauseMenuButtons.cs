using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _ContinueButton;
    [SerializeField] private Button _ExitButton;
    [SerializeField] private GameObject _pauseMenu;

    private bool _isOpened;

    private void Start()
    {
        _isOpened = false;

        _pauseButton.onClick.AddListener(PauseButton);
        _ContinueButton.onClick.AddListener(PauseButton);
        _ExitButton.onClick.AddListener(ExitButton);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseButton();
        }
    }

    private void PauseButton()
    {
        if (_isOpened)
        {
            Cursor.lockState = CursorLockMode.Locked;
            _pauseMenu.SetActive(false);
            Time.timeScale = 1;
            _isOpened = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            _pauseMenu.SetActive(true);
            Time.timeScale = 0;
            _isOpened = true;
        }

    }

    private void ExitButton()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }
}

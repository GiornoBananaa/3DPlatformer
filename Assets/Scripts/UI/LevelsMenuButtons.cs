using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenuButtons : MonoBehaviour
{
    [SerializeField] private Button _level1Button;
    [SerializeField] private Button _level2Button;
    [SerializeField] private Button _level3Button;
    [SerializeField] private Button _backButton;
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _LevelsMenu;

    private int _levelsProgress;

    private void Start()
    {
        _levelsProgress = PlayerPrefs.GetInt("Level", 1);

        _backButton.onClick.AddListener(() => BackButton());


        _level1Button.onClick.AddListener(() => SceneManager.LoadScene(1));

        if (_levelsProgress > 1)
            _level2Button.onClick.AddListener(() => SceneManager.LoadScene(2));
        else
            _level2Button.interactable = false;


        if (_levelsProgress > 2)
            _level3Button.onClick.AddListener(() => SceneManager.LoadScene(3));
        else
            _level3Button.interactable = false;
    }

    private void BackButton()
    {
        _mainMenu.SetActive(true);
        _LevelsMenu.SetActive(false);
    }
}

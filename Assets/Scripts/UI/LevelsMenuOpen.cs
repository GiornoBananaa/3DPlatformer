using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsMenuOpen : MonoBehaviour
{
    [SerializeField] private Button _LevelsButton;
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private GameObject _mainMenu;

    private void Start()
    {
        _LevelsButton.onClick.AddListener(() => LevelsButton());
    }

    private void LevelsButton()
    {
        _levelsPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

}

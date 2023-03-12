using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Button _continueButton;

    private void Start()
    {
        _continueButton.onClick.AddListener(() => SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1)));
    }
}

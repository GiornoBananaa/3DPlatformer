using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintCanCollector : MonoBehaviour
{
    [SerializeField] private int _playerLayer;

    private int _sprayCans;

    void Start()
    {
        PlayerPrefs.GetInt("Cans", 0);
        SceneManager.activeSceneChanged += SaveData;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _playerLayer)
        {
            Destroy(other.gameObject);
            _sprayCans++;
        }
    }

    private void SaveData(Scene current, Scene next)
    {
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}

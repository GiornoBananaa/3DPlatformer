using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovementController>())
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

            if (nextScene != 4) PlayerPrefs.SetInt("Level", nextScene);
            PlayerPrefs.Save();

            SceneManager.LoadScene(nextScene);
        }
    }
}

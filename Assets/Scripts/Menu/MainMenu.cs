using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void PlayGame() {
        SceneManager.LoadScene("FirstStage");
    }

    public void QuitGame() {
        Debug.Log("Quit the game succefully, but when is played in unity will do nothing :(");
        Application.Quit();
    }
}

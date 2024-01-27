using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    private string loadScene = "MainMenu";
    public GameObject pauseMenuUi;
    public GameObject diedMenuUi;
    public PlayerHealthBar playerHealth;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused) {
                ResumeGame();
            }
            else{
                PauseGame();
            }
        }
    }

    public void ResumeGame(){
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void PauseGame() {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(loadScene);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void RestartGame(){
        diedMenuUi.SetActive(false);
        string scene = SceneManager.GetActiveScene().name;
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }
}

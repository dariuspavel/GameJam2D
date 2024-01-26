using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject bossPlayer;

    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!bossPlayer.activeSelf)
        {
            Debug.Log("YouWon");
            win.SetActive(true);

            PauseGame();
        }

    }

    void PauseGame()
    {
        // Set the time scale to 0 to pause the game
        Time.timeScale = 0.1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{

    public GameObject diedMenuUi;
    public PlayerHealthBar playerHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDied();

    }
    // For test purpose, to be deleted later!!!
    public void TakeDamage (float damage){
        playerHealthBar.currentPlayerHealth -= damage;
        playerHealthBar.SetHealth(playerHealthBar.currentPlayerHealth);
    }

    void PlayerDied () {
         
        if (playerHealthBar.currentPlayerHealth <= 0) 
        {
            diedMenuUi.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
        }
    }   
}

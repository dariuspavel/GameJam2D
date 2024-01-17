using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    // Player max health
    private float playerMaxHealth = 100f;
    public float currentPlayerHealth;
    // Health bar has attached a slider which display the health
    public Slider healthSlider;

    void Start(){
        // Initialise the slider and player health
        currentPlayerHealth = playerMaxHealth;
        SetMaxHealth(playerMaxHealth);
    }

    void Update(){
    
    }
    
    // This function set's the max value the slider can have and also set the value
    public void SetMaxHealth(float health){
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    // This function set's the health value
    public void SetHealth(float health){
        healthSlider.value = health;
   }

}

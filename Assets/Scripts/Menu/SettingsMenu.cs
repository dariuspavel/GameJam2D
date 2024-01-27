using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public Sprite[] storeMuteIcons;
    public UnityEngine.UI.Image muteButton;

    public void SetVolume(float volume) {
        audioSource.volume = volume;
    }

    public void SetMuteIcon(float volume){
        if (volume > 0.80) {
            muteButton.sprite = storeMuteIcons[0];
        } else if (volume < 0.80 && volume > 0.60) {
            muteButton.sprite = storeMuteIcons[1];
        } else if (volume < 0.60 && volume > 0.40) {
            muteButton.sprite = storeMuteIcons[2];
        }else if (volume < 0.40 && volume > 0.20) {
            muteButton.sprite = storeMuteIcons[3];
        } else {
            muteButton.sprite = storeMuteIcons[4];
        }
        
    }
}

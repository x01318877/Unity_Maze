using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    static Music instance = null;

    private void Awake()
    {
        //no addtional game objects are being constantly spammed
        if (instance != null)
        {
            Destroy(gameObject);
        }
        //keep the music to the next scene
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    //Using for mute and unmute the background music
    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
            //AudioListener.volume = 1;
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
            //AudioListener.volume = 0;
        }
    }
}

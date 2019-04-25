using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour {

    public Music music;
    public Button musicToggleButton;

    // Use this for initialization
    void Start()
    {
        music = GameObject.FindObjectOfType<Music>();
    }

    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateVolume();
    }

    void UpdateVolume()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}

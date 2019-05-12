using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour {

    public void ClearData()
    {
        //Use to clear the high score if it's too high
        PlayerPrefs.DeleteAll();
    }

    
}

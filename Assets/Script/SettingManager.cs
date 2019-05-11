using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour {
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown txttureDropdown;
    
    //resolution array for index
    public Resolution[] resolutions;
    public GameSetting gameSetting;

    private void OnEnable()
    {
        gameSetting = new GameSetting();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolution(); });
        txttureDropdown.onValueChanged.AddListener(delegate { OnTxtQuality(); });

        resolutions = Screen.resolutions;

        foreach (Resolution resolution in resolutions)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }
    }

    public void OnFullScreenToggle()
    {
        gameSetting.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
    }

    public void OnResolution()
    {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, Screen.fullScreen);
    }

    public void OnTxtQuality()
    {
        QualitySettings.masterTextureLimit = gameSetting.txtQuality = txttureDropdown.value;
    }
}

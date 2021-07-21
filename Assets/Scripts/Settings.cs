using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{  
    public AudioMixer audioMixer;
    public AudioMixer sfxMixer;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
    void Start()
    {
        resolutions = Screen.resolutions; // sets the resolution to screen resolution
        resolutionDropdown.ClearOptions(); // clear all the options in dropdown
        List<string> options = new List<string>(); // list of string with all the options

        int currentResolutionIndex = 0; // current resolution index
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height; // finds the resolution possibilities
            options.Add(option); // adds the option 

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height )
            {
                currentResolutionIndex = i; // sets the current resolution index to be i value
            }

;       }  // loop through all elements which desplay the resolution in the list

        resolutionDropdown.AddOptions(options); // adds the option to dropdown list
        resolutionDropdown.value = currentResolutionIndex; // sets the current resolution value as first value in drop down list
        resolutionDropdown.RefreshShownValue(); // refreshes the shown value
    }

    public void SetMusicVolume(float volume)
    {
        Debug.Log(volume); // shows the volume number in consol
        audioMixer.SetFloat("Volume", volume); // sets the sound level as a float
    } // adjust the volume with slider in settings

    public void SetSFXVolume(float SFX)
    {
        Debug.Log(SFX); // shows the volume number in consol
        sfxMixer.SetFloat("SFX", SFX); // sets the sound level as a float
    } // adjust the volume with slider in settings

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex); // set quality setting to their index number
    } // adjust quality settings

    public void setFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen; // bool allows to toggle full screen
    } // set the screen full screen

    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    

}

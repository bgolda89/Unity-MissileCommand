using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

    public static float musicVol, sfxVol;
    public Slider musicSlider, sfxSlider;
    public AudioMixer mainMixer, sfxMixer; 

    public void SetMainVolume(float volume)
    {
        mainMixer.SetFloat("MainVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        sfxMixer.SetFloat("SFXVolume", volume);
    }

    public void SliderValues()
    {
        mainMixer.GetFloat("MainVolume", out musicVol);
        musicSlider.value = musicVol;

        sfxMixer.GetFloat("SFXVolume", out sfxVol);
        sfxSlider.value = sfxVol;
    }
}

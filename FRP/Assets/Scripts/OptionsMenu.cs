using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OptionsMenu : MonoBehaviour {
    public AudioMixer music_mix;
    public AudioMixer SFX_mix;
    public Slider music_slider;
    public void MusicVolume(float slider_music_volume)
    {
        music_mix.SetFloat("Volume", slider_music_volume);
    }
    public void SfXVolume(float slider_SFX_volume)
    {
        SFX_mix.SetFloat("SFX", slider_SFX_volume);
    }
	// Use this for initialization
	public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Start () 
    {   
		music_mix.SetFloat("Volume",music_slider.value);
	}
}

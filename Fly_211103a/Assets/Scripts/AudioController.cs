using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public int maxVolume = 0;
    public float presentVolume;
    public Slider volumeSlider;
    public Sprite unmuted;
    public Sprite muted;
    public static bool isMuted = false;
    public Button muteButton;
    

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.SetFloat("volume", 0);
        presentVolume = maxVolume;
        volumeSlider.value = presentVolume;
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        if (volume != -80)
        {
            presentVolume = volume;
            volumeSlider.value = presentVolume;
        }
        else
        {
            volumeSlider.value = -80;
        }
    }


    public void volumeMuted()
    {
        if(isMuted == false)
        {
            SetVolume(-80);
            muteButton.image.sprite = muted;
            isMuted = true;
        }
        else
        {
            SetVolume(presentVolume);
            muteButton.image.sprite = unmuted;
            isMuted = false;
        }
    }
}

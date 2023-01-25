using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoundVolumeController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource MusicBG;
    [SerializeField] private Slider VolumeMusicController;
    [SerializeField] private TextMeshProUGUI IntVolume;
    [Header("Keys")]
    [SerializeField] private string saveVolumeKey;
    [Header("Parametrs")]
    [SerializeField] private float volume;
    [Header("Tags")]
    [SerializeField] private string sliderTag;
    [SerializeField] private string textVolumeTag;

    private void Awake()
    {
        //GetMusic();
        if (PlayerPrefs.HasKey(this.saveVolumeKey))
        {
            this.volume = PlayerPrefs.GetFloat(this.saveVolumeKey);
            this.MusicBG.volume = this.volume;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if (sliderObj != null)
            {
                this.VolumeMusicController = sliderObj.GetComponent<Slider>();
                this.VolumeMusicController.value = this.volume;
            }
        }
        else
        {
            this.volume = 0.5f;
            PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
            this.MusicBG.volume = this.volume;
        }
    }

   private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);

        if (sliderObj != null)
        {
            this.VolumeMusicController = sliderObj.GetComponent<Slider>();
            this.volume = VolumeMusicController.value;

            if (this.MusicBG.volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
            }

            GameObject textObj = GameObject.FindWithTag(this.textVolumeTag);
            if (textObj != null)
            {
                
                this.IntVolume = textObj.GetComponent<TextMeshProUGUI>();
                this.IntVolume.text = Mathf.Round(f: this.volume * 100) + "%";
            }
        }

        this.MusicBG.volume = this.volume;
    }

   //void GetMusic()
    //{
     //   MusicBG = GetComponents<AudioSource>();
    //}
}

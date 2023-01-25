using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedScript : MonoBehaviour
{
    
    public GameObject pause;
    public static bool IndPause = false;

    public AudioSource[] Sounds;

    AudioSource SnakeMoveSound;
    AudioSource TorchSound;
    AudioSource LavaSound;


    void Start()
    {
        Sounds = GetComponents<AudioSource>();
        SnakeMoveSound = Sounds[0];
        TorchSound = Sounds[1];
        LavaSound = Sounds[2];
        
        this.TorchSound.Play();
        this.SnakeMoveSound.Play();
        this.LavaSound.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IndPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        IndPause = false;
        this.SnakeMoveSound.Play();
        this.TorchSound.Play();
        this.LavaSound.Play();
    }

    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        IndPause = true;
        this.SnakeMoveSound.Pause();
        this.TorchSound.Pause();
        this.LavaSound.Pause();
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}

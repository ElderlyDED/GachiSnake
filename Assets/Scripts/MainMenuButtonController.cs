using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonController : MonoBehaviour
{
   

    public GameObject DifMenu;
    public GameObject MainMenuActive;
    public GameObject SettingsMenu;
    public GameObject KeyBindsMenu;
    public GameObject Developers;
    public float plusSpeed;
    public int IndxHighScore;
 
    public void GoDevelopersButton()
    {
       Developers.SetActive(true);
       MainMenuActive.SetActive(false);
    }

    public void GoExitDevelopersButton()
    {
        Developers.SetActive(false);
        MainMenuActive.SetActive(true);
    }

    public void GoPlayButtonClick()
    {
        DifMenu.SetActive(true);
        MainMenuActive.SetActive(false);
       
    }

    public void GoExitPlayButtonClick()
    {
        DifMenu.SetActive(false);
        MainMenuActive.SetActive(true);
    }

    public void GoSettingsClick()
    {
        SettingsMenu.SetActive(true);
        MainMenuActive.SetActive(false);
    }

    public void GoExitSettingsClick()
    {
        SettingsMenu.SetActive(false);
        MainMenuActive.SetActive(true);
    }

    public void GoKeybindsClick()
    {
        SettingsMenu.SetActive(false);
        KeyBindsMenu.SetActive(true);
    }

    public void GoExitKeybindsClick()
    {
        SettingsMenu.SetActive(true);
        KeyBindsMenu.SetActive(false);
    }

    public void GoExitButtonClick()
    {
        Application.Quit();
    }

    public void EasyGoButton()
    {
        Invoke("EasyGoButtonInvoke", 2.5f);
       
    }

    public void EasyGoButtonInvoke()
    {
        SceneManager.LoadScene(1);
        plusSpeed = 0.2f;
        IndxHighScore = 1;
        PlayerPrefs.SetFloat("PlusS", plusSpeed);
        PlayerPrefs.SetInt("IndxHS", IndxHighScore);
    }

    public void MediumGoButton()
    {
        Invoke("MediumGoButtonInvoke", 1f);
    }

    public void MediumGoButtonInvoke()
    {
        SceneManager.LoadScene(1);
        plusSpeed = 0.4f;
        IndxHighScore = 2;
        PlayerPrefs.SetFloat("PlusS", plusSpeed);
        PlayerPrefs.SetInt("IndxHS", IndxHighScore);
    }

    public void HardGoButton()
    {
        Invoke("HardGoButtonInvoke", 4f);
    }

    public void HardGoButtonInvoke()
    {
        SceneManager.LoadScene(1);
        plusSpeed = 0.6f;
        IndxHighScore = 3;
        PlayerPrefs.SetFloat("PlusS", plusSpeed);
        PlayerPrefs.SetInt("IndxHS", IndxHighScore);
    }
}

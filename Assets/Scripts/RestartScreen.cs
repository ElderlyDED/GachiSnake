using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour
{
    public void RestartG()
    {
        Invoke("RestartGInvoke", 1f);
    }

    public void RestartGInvoke()
    {
        SceneManager.LoadScene(1);
    }

    public void GoMenu()
    {
        Invoke("GoMenuInvoke", 0.5f);
    }

    public void GoMenuInvoke()
    {
        SceneManager.LoadScene(0);
    }
}


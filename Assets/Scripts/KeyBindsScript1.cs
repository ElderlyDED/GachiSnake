using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBindsScript1 : MonoBehaviour
{
    public int IndKeyBinds;
    public GameObject ArrowsButtun;
    public GameObject ADButtun;

     void Start()
    {
        SwitchSaver();
    } 

     public void ADButtunGo()
     {
        ADButtun.SetActive(true);
        ArrowsButtun.SetActive(false);
        IndKeyBinds = 1;
        PlayerPrefs.SetInt("IndxKeyBinds", IndKeyBinds);
     }

    public void ArrowsButtunGo()
    {
        ADButtun.SetActive(false);
        ArrowsButtun.SetActive(true);
        IndKeyBinds = 2;
        PlayerPrefs.SetInt("IndxKeyBinds", IndKeyBinds);
    }

    public void SwitchSaver()
    {
        if(IndKeyBinds == 1)
        {
            ADButtun.SetActive(true);
            ArrowsButtun.SetActive(false);
        }
        if (IndKeyBinds == 2)
        {
            ArrowsButtun.SetActive(true);
            ADButtun.SetActive(false);
        }
    }
}

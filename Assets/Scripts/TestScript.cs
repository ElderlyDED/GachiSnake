using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Text IndxHSText;
    

    public void Start()
    {
        if (PlayerPrefs.GetInt("IndxHS") == 1)
        {
            IndxHSText.text = "Difficulty Easy";
        }
        if (PlayerPrefs.GetInt("IndxHS") == 2)
        {
            IndxHSText.text = "Difficulty Medium"; 
        }
        if (PlayerPrefs.GetInt("IndxHS") == 3)
        {
            IndxHSText.text = "Difficulty Hard";
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreWriterS : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.GetInt("IndxHS") == 1)
        {
            GetComponent<Text>().text = "HighScore (Easy) = " + PlayerPrefs.GetInt("HighScoreRecorderEasy").ToString();
        }
        if (PlayerPrefs.GetInt("IndxHS") == 2)
        {
            GetComponent<Text>().text = "HighScore (Medium) = " + PlayerPrefs.GetInt("HighScoreRecorderMedium").ToString();
        }
        if (PlayerPrefs.GetInt("IndxHS") == 3)
        {
            GetComponent<Text>().text = "HighScore (Hard) = " + PlayerPrefs.GetInt("HighScoreRecorderHard").ToString();
        }
    }

    
}

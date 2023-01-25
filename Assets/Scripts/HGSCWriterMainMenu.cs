using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HGSCWriterMainMenu : MonoBehaviour
{
    public TextMeshProUGUI hgdick;
    public TextMeshProUGUI hhdick;
    public TextMeshProUGUI hjdick;

    void Start()
    {
        hgdick.text = "HighScore (Easy) = " + PlayerPrefs.GetInt("HighScoreRecorderEasy").ToString();
        hhdick.text = "HighScore (Medium) = " + PlayerPrefs.GetInt("HighScoreRecorderMedium").ToString();
        hjdick.text = "HighScore (Hard) = " + PlayerPrefs.GetInt("HighScoreRecorderHard").ToString();
    }


}

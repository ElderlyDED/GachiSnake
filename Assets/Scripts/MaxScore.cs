using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{

    void Start()
    {
        GetComponent<Text>().text = "CUM = " + PlayerPrefs.GetInt("ScoreRecord").ToString();
    }

}   

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text timeTxt;
    public Text userNameTxt;
    public static GameManager I;

    public void Awake()
    {
        I = this;
    }
    void Update()
    {
        timeTxt.text = GetCurrentDate();
        userNameTxt.text = PlayerPrefs.GetString("User1", "Default Name");
    }

    public string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}

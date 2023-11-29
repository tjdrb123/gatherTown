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

    private string playerName = null;

    public void Awake()
    {
        I = this;
    }
    void Start()
    {
        playerName = PlayerPrefs.GetString("User1", "Default Name");
    }
    void Update()
    {
        timeTxt.text = GetCurrentDate();
        userNameTxt.text = playerName;
    }

    public string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}

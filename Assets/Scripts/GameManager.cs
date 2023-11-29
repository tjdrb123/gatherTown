using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text timeTxt;
    public static GameManager I;

    public void Awake()
    {
        I = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        timeTxt.text = GetCurrentDate();
    }

    public string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}

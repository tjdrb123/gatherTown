using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }
    void Start()
    {

    }
    void Update()
    {
        if (playerName.Length > 0 && playerName.Length < 10)
        {
            InputName();
        }
        else
        {

        }
    }
    public void InputName()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}

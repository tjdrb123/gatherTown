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

    public void GameStart()
    {
        playerName = playerNameInput.text;
        if (playerName.Length > 2 && playerName.Length < 10)
        {
            InputName();
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            playerNameInput.text = "2~10자 사이로 입력하세요.";
            playerName = null;
        }
    }

    public void InputName()
    {
        PlayerPrefs.SetString("User1", playerName);
    }
}
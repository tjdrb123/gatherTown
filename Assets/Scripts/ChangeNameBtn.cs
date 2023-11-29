using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameBtn : MonoBehaviour
{
    public GameObject changeNamePanel;
    public InputField changeNameInput;
    private string playerName = null;

    public void Button2()
    {
        changeNamePanel.SetActive(true);
    }

    public void ChangeName()
    {
        playerName = changeNameInput.text;
        PlayerPrefs.SetString("User1", playerName);
        PlayerPrefs.Save();
        changeNamePanel.SetActive(false);
    }
}

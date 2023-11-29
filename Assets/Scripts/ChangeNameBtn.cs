using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameBtn : MonoBehaviour
{
    public GameObject changeNamePanel;
    public InputField changeNameInput;

    public void Button2()
    {
        changeNamePanel.SetActive(true);
    }

    public void ChangeName()
    {
        if(changeNameInput.text.Length > 2 && changeNameInput.text.Length < 10)
        {
            PlayerPrefs.SetString("User1", changeNameInput.text);
            changeNameInput.text = "";
            changeNamePanel.SetActive(false);
        }
        else
        {
            changeNameInput.text = "2~10자 사이로 입력하세요.";
        }
        
    }
}

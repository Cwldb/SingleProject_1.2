using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("InGameScene");
    }

    public void SettingBtn()
    {

    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}

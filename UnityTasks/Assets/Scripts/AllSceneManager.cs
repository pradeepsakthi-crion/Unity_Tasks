using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneManager : MonoBehaviour
{
    
    public void OnClick()
    {
        SceneManager.LoadScene("AboutScene", LoadSceneMode.Additive);
    }

    public void OnSettingsClick()
    {
        SceneManager.LoadScene("SettingScene", LoadSceneMode.Additive);
    }

    public void OnMenuClick()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
    }

    public void OnHomeClick()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene("SettingScene", LoadSceneMode.Additive);
    }
}

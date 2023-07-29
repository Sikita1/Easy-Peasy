using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Menu : MonoBehaviour
{

    public GameObject Help;

    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void HelpUp()
    {
        Help.SetActive(true);
    }

    public void HelpDown()
    {
        Help.SetActive(false);
    }

    public void Vkontacte()
    {
        Application.OpenURL("https://vk.com/club196340946");
    }

    public void Assessment()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.SikitaGames.EasyPeasy");
    }

    public void Loaging()
    {
        SceneManager.LoadScene(2);
    }

    public void Happiness()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            SceneManager.LoadScene(0);
        }

    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class BIN_TXT : MonoBehaviour
{
    public GameObject VPR;
    public Color gr;
    public Color fl;
    public Image th;
    public Text t;
    public Taks task;
    public True tru;
    public GameObject Error;

    public float TimeStart = 15f;
    public Text Timerr;
    public GameObject lose;

    public AudioClip Rirht;
    public AudioClip Lose;

    private static int advCount = 0;

    void Start()
    {
        Timerr.text = TimeStart.ToString();
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3658471", false);
        }
    }

    void Update()
    {
        if (TimeStart > 0)
        {
            TimeStart -= Time.deltaTime;
            Timerr.text = Mathf.Round(TimeStart).ToString();
        }
        else
        {
            Error.SetActive(true);
            lose.SetActive(false);
            if (PlayerPrefs.GetInt("Score") < tru.Score)
                PlayerPrefs.SetInt("Score", tru.Score);
        }
    }

    public void Check()
    {

        if (t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
            tru.Score = tru.Score + 1;
            GetComponent<AudioSource>().PlayOneShot(Rirht);
        }
        else
        {
            th.color = fl;
            StartCoroutine(W());
            GetComponent<AudioSource>().PlayOneShot(Lose);
            advCount++;
            if (Advertisement.IsReady("video") && advCount % 3 == 0)
            {
                Advertisement.Show("video");
            }
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
#pragma warning disable CS0618 // Тип или член устарел
        VPR.active = false;
#pragma warning restore CS0618 // Тип или член устарел
    }

    IEnumerator W()
    {
        yield return new WaitForSeconds(1);
        Error.SetActive(true);
        lose.SetActive(false);
        if (PlayerPrefs.GetInt("Score") < tru.Score)
            PlayerPrefs.SetInt("Score", tru.Score);
    }
}



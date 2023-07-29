using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public int I;
    public GameObject[] Questions;

    void Start()
    {
        Questions = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, Questions.Length);
#pragma warning disable CS0618 // Тип или член устарел
        Questions[I].transform.GetChild(0).gameObject.active = true;
#pragma warning restore CS0618 // Тип или член устарел
    }

    public void Randowm()
    {
        StartCoroutine(W());
    }
    IEnumerator W()
    {
        yield return new WaitForSeconds(1);
        Questions = null;
        Questions = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, Questions.Length);
#pragma warning disable CS0618 // Тип или член устарел
        Questions[I].transform.GetChild(0).gameObject.active = true;
#pragma warning restore CS0618 // Тип или член устарел
    }


    void Update()
    {
        
    }
}

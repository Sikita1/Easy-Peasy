using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taks : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string TasK;
    public string Answers;
    public Text Tesk;
    public string True;
    public List<Text> L;
    public int i = 0;


    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        TasK = s[0];
        Answers = s[1];
        True = s[2];
        Tesk.text = TasK;
        string[] A = Answers.Split(';');

        while (i < 4)
        {
            int E = Random.Range(0, L.Count);
            L[E].text = A[i];
            L.RemoveAt(E); 
            i += 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoading : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Animation>().Play("Loading");
    }
}

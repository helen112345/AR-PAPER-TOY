using UnityEngine;
using System.Collections;

public class start : MonoBehaviour
{

    void Awake()
    {
    }

    public void Startbutton()
    {
        Invoke("startgame", 5f);
    }

    void startgame()
    {
        Application.LoadLevel("1-Loading");
    }
}


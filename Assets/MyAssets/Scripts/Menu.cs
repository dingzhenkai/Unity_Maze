using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    void OnGUI()
    {
        if (GUI.Button(new Rect(900, 650, 100, 30), "开始游戏"))
        {
            //Application.LoadLevel("01");
            SceneManager.LoadScene("01");

        }

        if (GUI.Button(new Rect(1100, 650, 100, 30), "退出"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif

        }

        if (GUI.Button(new Rect(700, 650, 100, 30), "Euler"))
        {
            //Application.LoadLevel("01");
            SceneManager.LoadScene("01");

        }

        if (GUI.Button(new Rect(500, 650, 100, 30), "Trapezoid"))
        {
            //Application.LoadLevel("01");
            SceneManager.LoadScene("02");
        }

        if (GUI.Button(new Rect(300, 650, 100, 30), "Midpoint"))
        {
            //Application.LoadLevel("01");
            SceneManager.LoadScene("03");
        }




    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
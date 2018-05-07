using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SimpleUI : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 30), "replay"))
        {
            //Application.LoadLevel("01");
            SceneManager.LoadScene("01");

        }
        if (GUI.Button(new Rect(0, 30, 100, 30), "pause"))
        {
            //Application.LoadLevel("01");
            //SceneManager.LoadScene("01");
            Time.timeScale = 0;

        }
        if (GUI.Button(new Rect(0, 60, 100, 30), "continue"))
        {
            //Application.LoadLevel("01");
            //SceneManager.LoadScene("01");
            Time.timeScale = 1;

        }
        if (GUI.Button(new Rect(0, 90, 100, 30), "exit"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif

        }

    }
}

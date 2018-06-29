using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class Tank : MonoBehaviour {

    public float movespeed = 15;
    public float rotatespeed = 60;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotatespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);
        }
    }
}

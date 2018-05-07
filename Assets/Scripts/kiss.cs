using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiss : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Main Camera").GetComponent<Shoot>().steps++;
        //Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

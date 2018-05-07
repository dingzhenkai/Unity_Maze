using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followperson : MonoBehaviour {

    public Transform target;
    public float distanceZ = 3f;
    public float distanceY = 3f;
    public float distanceX = 0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        Vector3 nextpos = target.forward * -1 * distanceZ + target.up * distanceY + target.position + target.right * distanceX;
        this.transform.position = nextpos;
        //this.transform.rotation = target.rotation;
        this.transform.LookAt(target);
    }
}

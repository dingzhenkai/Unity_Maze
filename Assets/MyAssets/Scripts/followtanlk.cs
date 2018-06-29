using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtanlk : MonoBehaviour {

    public Transform target;
    public float distanceZ = 0f;
    public float distanceY = 8f;
    public float distanceX = 29f;


    void LateUpdate()
    {
        Vector3 nextpos = target.forward * -1 * distanceZ + target.up * distanceY + target.position + target.right * distanceX;
        this.transform.position = nextpos;
        //this.transform.rotation = target.rotation;
        this.transform.LookAt(target);
    }
}

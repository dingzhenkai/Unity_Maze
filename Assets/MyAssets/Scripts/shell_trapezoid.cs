using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell_trapezoid : MonoBehaviour {

    public float Gravity = -10;
    private Vector3 MoveSpeed;
    private Vector3 GritySpeed = Vector3.zero;
    private float dTime;


    public float shootpower = 100;
    public Vector3 direction = Vector3.zero;
    public float mass = 1;
    private Vector3 LastSpeed = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        shootpower = GameObject.Find("Tank").GetComponent<TankWeapon>().shootpower;
        direction = GameObject.Find("Tank").GetComponent<TankWeapon>().shootdirection;
        mass = GameObject.Find("Tank").GetComponent<TankWeapon>().mass;
        Vector3 shootdirection = transform.forward + direction;
        MoveSpeed = initspeed(shootdirection, shootpower, mass);
        Debug.Log(dTime + ":" + transform.position);
        Debug.Log(dTime + ":" + MoveSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime);
        Vector3 NowSpeed = MoveSpeed + GritySpeed;

        //transform.position = ((NowSpeed + LastSpeed)/2) * Time.fixedDeltaTime + transform.position;
        transform.position += ((NowSpeed + LastSpeed) / 2) * Time.fixedDeltaTime;
        LastSpeed = NowSpeed;
        Debug.Log(dTime + ":" + transform.position);
        Debug.Log(dTime + ":" + ((NowSpeed + LastSpeed) / 2) * Time.fixedDeltaTime);

    }
    Vector3 initspeed(Vector3 shootdirection, float shootpower, float mass)
    {
        return shootdirection * shootpower * (shootpower / (shootpower + mass));
    }
}

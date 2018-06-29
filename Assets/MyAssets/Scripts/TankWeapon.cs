using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankWeapon : MonoBehaviour {

    public GameObject shell;
    public float shootpower = 10;
    public Vector3 shootdirection;
    public float mass = 1;
    public Transform shootPoint;

    public string s_power,s_x,s_y,s_z,s_mass,s_mode;
    public Vector3 s_direction;
    void Start()
    {
        s_power = "";
        s_x = "";
        s_y = "";
        s_z = "";
        s_mass = "";
        s_mode = "";
        s_direction = Vector3.zero;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 30), "请输入发射力量，发射方向，炮弹质量");
        GUI.Label(new Rect(20, 50, 60, 30), "发射力量");
        GUI.Label(new Rect(20, 80, 60, 30), "发射方向");
        GUI.Label(new Rect(20, 110, 60, 30), "炮弹质量");
        GUI.Label(new Rect(20, 140, 60, 30), "计算模式");
        s_power = GUI.TextField(new Rect(80, 50, 100, 20), s_power, 15);
        s_x = GUI.TextField(new Rect(80, 80, 20, 20), s_x, 15);
        s_y = GUI.TextField(new Rect(100, 80, 20, 20), s_y, 15);
        s_z = GUI.TextField(new Rect(120, 80, 20, 20), s_z, 15);
        s_mass = GUI.TextField(new Rect(80, 110, 100, 20), s_mass, 15);
        s_mode = GUI.TextField(new Rect(80, 140, 100, 20), s_mode, 15);
        if (GUI.Button(new Rect(20, 150, 60, 30), "OK"))
        {
            shootpower = float.Parse(s_power);
            shootdirection = new Vector3(float.Parse(s_x), float.Parse(s_y), float.Parse(s_z));
            mass = float.Parse(s_mass);
            //Debug.Log(shootpower);
        }


        /*shootpower = float.Parse(s_power);
        shootdirection = new Vector3(float.Parse(s_x), float.Parse(s_y), float.Parse(s_z));
        mass = float.Parse(s_mass);*/
    }

    void Shoot() {
        GameObject newshell = Instantiate(shell,shootPoint.position ,shootPoint.rotation) as GameObject;
        /*Rigidbody r = newshell.GetComponent<Rigidbody>();
        r.velocity = shootPoint.forward * shootpower;*/
        /*Vector3 f = shootPoint.forward;
        newshell.GetComponent<Rigidbody>().AddForce(f * shootpower);*/
    }
}

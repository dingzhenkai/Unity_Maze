using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.ThirdPerson;

public class Shoot : MonoBehaviour {

    public Transform Q; //实例化
    public Transform target;
    int speed = 50;
    public int shot = 0;
    public int dead = 0;
    float timer_f = 0.0f;
    int timer_i = 0;
    float life = 0.001f;
    public int steps = 0;






    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //发射小球
       /* if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Transform n = (Transform)Instantiate(Q, target.position, target.rotation);
            Vector3 f = n.transform.forward;
            n.GetComponent<Rigidbody>().AddForce(f * 2000);
            //Destroy(n.gameObject, life);
            
            shot++;
            
        }*/
        timer_f += Time.deltaTime;
        timer_i = (int)timer_f;
        GameObject.Find("Canvas/time").GetComponent<Text>().text = "已用时   " + timer_i;
        GameObject.Find("Canvas/step").GetComponent<Text>().text = "体力消耗值   " + steps;

        if (timer_i > 100)
        {
            GameObject.Find("Canvas/time").GetComponent<Text>().text = "Sorry, 已超时，下次再努力吧";
            GameObject.Find("EthanBody").GetComponent<ThirdPersonUserControl>().enabled = false;
            GameObject.Find("EthanBody").GetComponent<ThirdPersonCharacter>().enabled = false;

        }
        if (gameObject.transform.position.z < 214)
        {

            GameObject.Find("Canvas/time").GetComponent<Text>().text = "恭喜你，走出迷宫";
        }
    }
}

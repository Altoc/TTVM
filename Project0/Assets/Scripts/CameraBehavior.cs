using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {

    public GameObject paddle;
    public GameObject player;

    public GameObject ball;

    //Vector3 origin;

    // Use this for initialization
    void Start()
    {
        paddle = GameObject.Find("PlayerPaddle");
        player = GameObject.Find("Player");
        //origin = this.transform.position;
    }

    void Update()
    {
        /*
        //paddle.transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKeyDown("space"))
        {
            GameObject ballClone = Instantiate(ball, transform.position, transform.rotation) as GameObject;
            ballClone.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
        }
        */

        transform.position = new Vector3(player.transform.position.x, 2.5f, player.transform.position.z);
    }
}

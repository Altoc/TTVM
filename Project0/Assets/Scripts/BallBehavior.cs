using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

    public GameObject player;
    public GameObject opponent;

    public float OpponentThrust;
    public float playerThrust;
    public float serveThrust;
    //public float speed;
    //public float deceleration;
    public Rigidbody rb;

    void Start()
    {
        player = GameObject.Find("PlayerPaddle");
        opponent = GameObject.Find("Opponent01");
        playerThrust = player.GetComponent<PaddleBehavior>().playerThrust;
        OpponentThrust = opponent.GetComponent<Opponent01Behavior>().OpponentThrust;

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * serveThrust);
    }

    void FixedUpdate()
    {
        //Debug.Log("Speed: " + speed);
        //Debug.Log("Decell: " + deceleration);
        //Debug.Log("Thrust: " + thrust);
        /*
        if (speed > 0) {
            speed -= (Time.deltaTime * deceleration);
            rb.AddForce(transform.forward * speed);
        }
        else if (speed <= 0)
            speed = 0;
        */
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlayerPaddle") {
            rb.velocity += transform.forward * (playerThrust);
            //rb.AddForce(transform.forward * thrust);
            //speed = 1;
        }
        if (col.gameObject.name == "Opponent01")
        {
            rb.velocity += (transform.forward * -1 )* (OpponentThrust); // * -1 is the same as transform.backwards
            //rb.AddForce(transform.forward * thrust);
            //speed = 1;
        }
    }
}

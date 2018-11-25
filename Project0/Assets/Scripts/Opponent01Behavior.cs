using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent01Behavior : MonoBehaviour { 
    public GameObject ball;
    public float serveTime;
    public float OpponentThrust;

    private float serveTimer;
    private Vector3 rightMax;
    private Vector3 leftMax;
    private int switchDirection;

    // Use this for initialization
    void Start()
    {
        rightMax = new Vector3(-5, 2, -2);
        leftMax = new Vector3(-5, 2, 2);

        //transform.position = rightMax;

        switchDirection = 0;

        OpponentThrust = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchDirection == 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime, Space.World);    //go right
        }
        if (switchDirection == 1)
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World); //go left
        }
        
        if (transform.position.z <= rightMax.z) //if self reaches right side of board
        {
            switchDirection = 1;
        }
        if (transform.position.z >= leftMax.z) //if self reaches left side of board
        {
            switchDirection = 0;
        }

        //serveTimer -= 1 * Time.deltaTime;
        //if (serveTimer <= 0) {
            //Instantiate(ball, new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z), Quaternion.Euler(0, 270, 0));
            //serveTimer = serveTime;
        //}

    }
}

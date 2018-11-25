using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour {
    
    public float distance = 1.0f;
    public GameObject ball;
    public float playerThrust;

    private Vector3 ballSpawnLocation;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        //paddle.transform.rotation = Quaternion.Euler(0, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            GameObject ballClone = Instantiate(ball, transform.position, transform.rotation) as GameObject;
            ballClone.GetComponent<Rigidbody>().AddForce(playerThrust, transform.position.y, transform.position.z, ForceMode.Force);    //(Vector3.forward * playerThrust);   //Vector3.forward for stationary, transform.forward for FPS
        }
        /*
        ballSpawnLocation = new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z + 1);

        if (Input.GetKeyDown("space"))
        {
            Instantiate(ball, ballSpawnLocation, Quaternion.identity);//new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 270, 0));
        } 
        */
    }
}

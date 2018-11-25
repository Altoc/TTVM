using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDexterityBehavior : MonoBehaviour
{
    //public GameObject player;
    public GameObject GameMaster;

    //public float playerThrust;
    //public float serveThrust;

    void Start()
    {
        //player = GameObject.Find("PlayerPaddle");
        //playerThrust = player.GetComponent<PaddleBehavior>().playerThrust;
    }

    void FixedUpdate()
    {
        
    }
    /*
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlayerPaddle")
        {
            rb.velocity += transform.forward * (playerThrust);
        }
    }
    */
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "GoalDetection")
        {
            Debug.Log("Goal Detected!");
            GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().objectiveMet = true;
        }

        if (col.gameObject.name == "DexterityTestsDetection")
        {
            Debug.Log("Dexterity Detected!");
            GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().gameMode = 2;
            GameObject.Find("Dexterity Tests").GetComponent<ScrDexterityTestMenuSelector>().selected = true;
        }

        if (col.gameObject.name == "TrickShotsDetection")
        {
            Debug.Log("Trick Detected!");
            GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().gameMode = 3;
            GameObject.Find("Trick Shots").GetComponent<ScrTrickShotsMenuSelector>().selected = true;
        }

        if (col.gameObject.name == "BeerPongDetection")
        {
            Debug.Log("Beer Detected!");
            GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().gameMode = 1;
            GameObject.Find("Beer Pong").GetComponent<ScrBeerPongMenuSelector>().selected = true;
        }

        if (col.gameObject.name == "PaddleChangerDetector")
        {
            Debug.Log("Paddle Changer Detected!");
            GameObject.Find("PaddleChanger").GetComponent<ScrPaddleChanger>().selected = true;
        }
    }
}
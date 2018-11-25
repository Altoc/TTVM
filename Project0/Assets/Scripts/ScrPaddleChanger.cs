using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPaddleChanger : MonoBehaviour {

    public bool selected;
    public int skinID;

    public Material skin01;
    public Material skin02;
    public Material skin03;
    public Material skin04;

    private GameObject paddle;
    private int amtOfSkins;
    // Use this for initialization
    void Start()
    {
        selected = false;
        skinID = 0;
        paddle = GameObject.Find("PlayerPaddle");
        amtOfSkins = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (selected == true)
        {
            PaddleSkinSwitch(skinID);
            skinID++;
            if (skinID > (amtOfSkins - 1)) {
                skinID = 0;
            }
            selected = false;
        }
    }

    public void PaddleSkinSwitch(int skinID)
    {
        switch (skinID) {
            case 0: paddle.GetComponent<MeshRenderer>().material = skin01; break;
            case 1: paddle.GetComponent<MeshRenderer>().material = skin02; break;
            case 2: paddle.GetComponent<MeshRenderer>().material = skin03; break;
            case 3: paddle.GetComponent<MeshRenderer>().material = skin04; break;
        }
        
    }
}

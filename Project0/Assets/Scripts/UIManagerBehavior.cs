using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerBehavior : MonoBehaviour {

    public int gameMode;    //0 = menu, 1 = beerpong, 2 = dexterity, 3 = trickshot
    public int currTrickLevel;
    public int currDexLevel;
    public string objectiveText;
    public string winText;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        objectiveText = "";
        winText = "";
        currTrickLevel = 0;
        currDexLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameMode = GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().gameMode;

        if (gameMode == 2) {

            Debug.Log("Curr MODE: Dex");
            Debug.Log("Curr Lv: " + currDexLevel);

            currDexLevel = GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().level;

            if (currDexLevel == 1) {
                
                if (GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().objectiveMet == true)
                {
                    winText = "GOAL!";
                    objectiveText = "GOAL!";
                }
                else
                {
                    objectiveText = "Hit Opponet 5 times!";
                }
            }
        }

        if (gameMode == 3)
        {

            Debug.Log("Curr MODE: Trick");
            

            currTrickLevel = GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().level;

            if (currTrickLevel == 1) {

                Debug.Log("Curr Lv: " + currTrickLevel);

                if (GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().objectiveMet == true)
                {
                    winText = "GOAL!";
                    objectiveText = "GOAL!";
                }
                else {
                    objectiveText = "Get The Ball In The Hole!";
                }
            }
            if (currTrickLevel == 2)
            {

                Debug.Log("Curr Lv: " + currTrickLevel);

                if (GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().objectiveMet == true)
                {
                    winText = "GOAL!";
                    objectiveText = "GOAL!";
                }
                else
                {
                    objectiveText = "";
                }
            }
            if (currTrickLevel == 3)
            {

                Debug.Log("Curr Lv: " + currTrickLevel);

                if (GameObject.Find("GameMaster").GetComponent<GameMasterBehavior>().objectiveMet == true)
                {
                    winText = "GOAL!";
                    objectiveText = "GOAL!";
                }
                else
                {
                    objectiveText = "";
                }
            }
        }
    }
}

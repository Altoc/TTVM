using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMasterBehavior : MonoBehaviour {

    public bool objectiveMet;

    public int gameMode;    //0 = menu, 1 = beerpong, 2 = dexterity, 3 = trickshot
    public int level;
    public float levelSwitchTimer;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        objectiveMet = false;
        level = 1;
        gameMode = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (objectiveMet == true) {
            levelSwitchTimer = levelSwitchTimer - 1 * Time.deltaTime;
            if (levelSwitchTimer <= 0) {
                switch (gameMode) {
                    case 2: levelSwitchDex(level); break;
                    case 3: levelSwitchTrick(level); break;
                }
                levelSwitchTimer = 5;
                objectiveMet = false;
            }
        }
    }

    public void levelSwitchTrick(int lvl) {
        switch (lvl) {
            case 1: SceneManager.LoadScene("LvTrick02"); break;
            case 2: SceneManager.LoadScene("LvTrick03"); break;
        }
        lvl++;
    }

    public void levelSwitchDex(int lvl)
    {
        switch (lvl)
        {
            case 1: SceneManager.LoadScene("LvDex02"); break;
            case 2: SceneManager.LoadScene("LvDex03"); break;
        }
        lvl++;
    }
}

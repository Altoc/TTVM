using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrDexterityTestMenuSelector : MonoBehaviour {

    public bool selected;
    public float levelSwitchTimer;


    // Use this for initialization
    void Start()
    {
        selected = false;
	}
	
	// Update is called once per frame
	void Update()
    {
        if (selected == true)
        {
            levelSwitchTimer = levelSwitchTimer - 1 * Time.deltaTime;
            if (levelSwitchTimer <= 0)
            {
                DexterityLevelSwitch();
                selected = false;
            }
        }
    }

    public void DexterityLevelSwitch()
    {
        SceneManager.LoadScene("LvDex01");
    }
}

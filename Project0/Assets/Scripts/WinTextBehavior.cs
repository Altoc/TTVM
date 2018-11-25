using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextBehavior : MonoBehaviour {

    public GameObject UIManager;

    public Text text;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = GameObject.Find("UIManager").GetComponent<UIManagerBehavior>().winText;
    }
}

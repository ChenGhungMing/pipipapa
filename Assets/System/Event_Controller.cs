using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Controller : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void Awake()
    {
        GameObject[] button = new GameObject[3];

        button[0] = GameObject.Find("Btn_Select_01");
        button[1] = GameObject.Find("Btn_Select_02");
        button[2] = GameObject.Find("Btn_Select_03");
        UIEventListener.Get(button[0]).onClick = ButtonClick_1;
        UIEventListener.Get(button[1]).onClick = ButtonClick_2;
        UIEventListener.Get(button[2]).onClick = ButtonClick_3;
    }

    void ButtonClick_1(GameObject button)
    {
        Debug.Log("A" + button.name);
    }

    void ButtonClick_2(GameObject button)
    {
        Debug.Log("B" + button.name);
    }

    void ButtonClick_3(GameObject button)
    {
        Debug.Log("C" + button.name);
    }
}

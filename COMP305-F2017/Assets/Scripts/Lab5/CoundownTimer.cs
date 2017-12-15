using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoundownTimer : MonoBehaviour {

    public float timeCount = 30f;
    public Text timeText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeCount -= Time.deltaTime;
        timeText.text = "Time:" + timeCount.ToString("F2");
        if (timeCount < 0)
        {
            //Application.LoadLevel();
            Debug.Log("Next Game");
        }



    }
}

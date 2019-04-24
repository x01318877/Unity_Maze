using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

    float currentTime = 0f;
    float startingTime = 5f;

    [SerializeField]Text countdownText;

	// Use this for initialization
	void Start () {
        currentTime = startingTime;
	}

    void Update()
    {

        if (currentTime > 0)
        {
            //Decrease our current time by one by one each second
            currentTime -= 1 * Time.deltaTime;
            //"0" for only wanna see the whole numbers
            countdownText.text = "Time Left(s): " + currentTime.ToString("0") + "s";
        }
        //Do not wanna see the minus number
        else {
            countdownText.text = "Game Over!!!";
        }
    }
}

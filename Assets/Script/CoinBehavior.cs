using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour {

    GameManagerScript GMS;
    private float rotateSpeed = 10f;

    // Use this for initialization
    void Awake()
    {
        //Connection with the GameManager
        //We need to search the game manager in the scene at start and save on the connection to the game
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.cur_coins++;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.left * rotateSpeed);
    }

    //Destroy coins and decrease the amount of current coins
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            //Decrease coins
            GMS.cur_coins--;
            //adding score...
            GMS.UpdateUI();
        }

    }
}

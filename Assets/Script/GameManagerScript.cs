using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    // Check how many coins are left at the scene

    //Coin Left Text
    public Text coinsLeft;

    // Current amount of coins
    public int cur_coins = 0;
    public int max_coins = 0;

    public GameObject Door;

    // Use this for initialization
    void Start () {
        //Door only active when coin equal or less than zero
        Door.SetActive (false);
        max_coins = cur_coins;
        UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //public: can call this method in anywhere
    public void UpdateUI() {
        //At lease one coin left in the scene, update the text
        if (cur_coins > 0)
        {
            //D2: two digits
            coinsLeft.text = "Coins Left: " + cur_coins.ToString("D2") + "/" + max_coins.ToString("D2");
        }
        else if(cur_coins <= 0){
            Door.SetActive(true);
            coinsLeft.text = "Coins Left: " + cur_coins.ToString("D2") + "/" + max_coins.ToString("D2");
        }
        
    }
}

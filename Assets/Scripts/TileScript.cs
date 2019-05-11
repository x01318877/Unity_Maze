using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

    private float fallDelay = 0.85f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Called when a trigger exits in the collision box or something exits the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            TileManager.Instance.SpawnTile();
            StartCoroutine(FallDown());
        }
    }

    IEnumerator FallDown() {
        //the amount of seconds that the routine should stop before I execute the rest
        yield return new WaitForSeconds(fallDelay);
        //rigidbody is kinematic which means it will fall to the ground
        GetComponent<Rigidbody>().isKinematic = false;
        //when the tile falls down we need to make sure they get recycled after 2 second
        yield return new WaitForSeconds(2);
        switch (gameObject.name) {

            //TopTiles.Peek().name = "TopTile";
            case "LeftTile":
                //when tile done falling it will be add back to the stack and reuse
                TileManager.Instance.LeftTiles.Push(gameObject);
                //doesn't keep falling
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.SetActive(false);
                break;

            //LeftTiles.Peek().name = "LeftTile";
            case "TopTile":
                TileManager.Instance.TopTiles.Push(gameObject);
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.SetActive(false);
                break;
        }
    }
}

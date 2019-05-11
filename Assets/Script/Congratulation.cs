using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congratulation : MonoBehaviour {

    //public int levelToLoad;

    public GameObject congra;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Time.timeScale = 0;
            congra.gameObject.SetActive(true);
#pragma warning disable CS0618 // Type or member is obsolete
            //Application.LoadLevel(levelToLoad);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }

}

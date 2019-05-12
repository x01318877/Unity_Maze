using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton2 : MonoBehaviour {

    [SerializeField]
    private Transform puzzleField;

    //use it to create a for loop
    [SerializeField]
    private GameObject btn;

    private void Awake()
    {
        for (int i = 0; i < 12; i++)
        {
            //instantiate is a function of model behavior and create a copy of the game object that we provide
            //create copy of the button game object
            GameObject button = Instantiate(btn);
            //to name our button from 0 up to 9 (i < 10)
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }
    }
}

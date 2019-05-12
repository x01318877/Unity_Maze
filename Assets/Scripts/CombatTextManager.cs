using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatTextManager : MonoBehaviour {

    private static CombatTextManager instance;

    public GameObject textPrefab;

    public RectTransform canvasTransform;

    public float speed;

    public Vector3 direction;

    public float fadeTime;

    //camero's transform
    public Transform camTransform;

    public static CombatTextManager Instance
	   {
		   get
		   {
			   if(instance == null)
			   {
				 instance = GameObject.FindObjectOfType<CombatTextManager>();  
			   }
			   return instance;
		   }
	   }

    public void CreateText(Vector3 position, string text, Color color, bool crit)
    {
        GameObject sct = (GameObject)Instantiate(textPrefab, position, Quaternion.identity);

        //Make the text the child of the Canvas
        sct.transform.SetParent(canvasTransform);

        //Set the scale corretly from RectTransform Component
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);

        //call initialize function from CombatText.cs
        sct.GetComponent<CombatText>().Initialize(speed, direction, fadeTime, crit);

        //setup the corretly text
        sct.GetComponent<Text>().text = text;

        //change color of the text
        sct.GetComponent<Text>().color = color;
    }

}

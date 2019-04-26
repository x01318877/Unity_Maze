﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

    public float speed = 5.0f;

    //Audio Collider
    public AudioSource tickSource;

    // Use this for initialization


    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

        tickSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        //if we hit the space key, we gwt our cursor back
        if (Input.GetKeyDown("space"))
            Cursor.lockState = CursorLockMode.None;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin") {
            //Add sound when touch the object
            tickSource.Play();
        }
    }
}

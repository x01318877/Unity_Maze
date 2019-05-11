using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterController : MonoBehaviour
{

    public float speed = 5.0f;

    //Audio Collider
    public AudioSource tickSource;

    // Use this for initialization


    void Start()
    {
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

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin") {
            //Add sound when touch the object
            tickSource.Play();
        }

<<<<<<< HEAD

=======
        if (collision.gameObject.tag == "task")
        {
            //Add sound when touch the object
            SceneManager.LoadScene(7);
        }
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
    }
}

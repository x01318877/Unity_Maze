using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{

    //keep track how much movement the camera has made(total movement)
    Vector2 mouseLook;
    //smooth down the movement of the mouse, similar like multiplying our movement
    Vector2 smoothV;
    //mouse sensitivity, how much u need to move the mouse on the screen
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    //point back to our character, camera turn the whole body
    GameObject character;

    // Use this for initialization
    void Start()
    {
        //character is the parent of camera
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //get u the change of the mouse movement since the last update
        //md: mouse delta
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //look up
        if (mouseLook.y > 90)
        {
            mouseLook.y = 90;
        }

        //look downward
        else if (mouseLook.y < -90)
        {
            mouseLook.y = -90;
        }


        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        //- inverted system, y up down
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        //whole character move left right
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Vector3.up);
    }
}

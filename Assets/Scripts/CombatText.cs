using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatText : MonoBehaviour {

    //SCTCanvas can fix the text size
    
    private float speed;
    private Vector3 direction;
    private float fadeTime;

    //Text Zoom big small
    public AnimationClip critAnim;

    private bool crit;


    // Update is called once per frame
    void Update () {

        if (!crit)
        {
            float translation = speed * Time.deltaTime;
            //Move our text
            transform.Translate(direction * translation);
        }

    }

    //Turn the TEXT around rotate -- camero
    public void Start()
    {
        transform.LookAt(2 * transform.position - CombatTextManager.Instance.camTransform.position);
    }

    public void Initialize(float speed, Vector3 direction, float fadeTime, bool crit)
    {
        //in order to access private float speed;
        this.speed = speed;
        //in order to access private float fadeTime;
        this.fadeTime = fadeTime;
        //in order to access private Vector3 direction;
        this.direction = direction;

        this.crit = crit;

        if (crit)
        {
            GetComponent<Animator>().SetTrigger("Critical");
            StartCoroutine(Critical());
            StartCoroutine(Fadeout());
        }
        else
        {
            //so the fadeout could be worked
            StartCoroutine(Fadeout());
        }
        
    }

    //Critical Animation
    private IEnumerator Critical()
    {
        //we need to wait with the fading out until we are done showing the critical animation
        yield return new WaitForSeconds(critAnim.length);
        //we need to make sure the text doesn't move when it shows a critical
        crit = false;
        StartCoroutine(Fadeout());
    }

    private IEnumerator Fadeout()
    {
        float startAlpha = GetComponent<Text>().color.a;

        //text takes X amount of second to fade out
        float rate = 1.0f / fadeTime;

        //when progress = 1.0f, we done the fading and we should stop it
        float progress = 0.0f;

        while (progress < 1.0)
        {
            //store the information of the text color
            //tmp = temporary
            Color tmpColor = GetComponent<Text>().color;

            //we don't need to change the color RGB, just change the Alpha
            //we done faded when Alpha is 0, startAlpha = 255, when goes to 175, the progress = 0.5, when goes0, the progress = 1
            GetComponent<Text>().color = new Color(tmpColor.r, tmpColor.g, tmpColor.b, Mathf.Lerp(startAlpha, 0, progress));

            //updating the progress so that at some point we could stop
            progress += rate * Time.deltaTime;

            //continue this progress all the time
            yield return null;
        }

        //Delete the faded text
        Destroy(gameObject);
    }
}

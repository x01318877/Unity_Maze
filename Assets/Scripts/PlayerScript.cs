using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class PlayerScript : MonoBehaviour
{
=======
<<<<<<< HEAD
public class PlayerScript : MonoBehaviour
{
=======
public class PlayerScript : MonoBehaviour {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    //player speed(public means we can access our speed from the inspector)
    public float speed;
    //what direction the player moves in(how many times player clicks, 90 degree)
    private Vector3 dir;
    //z(+1) Direction: forward, x(-1) Direction: left
    //public Vector3 dir;

    //partical system
    public GameObject ps;

    private bool isDead;

    public GameObject resetBtn;

    //initial power score
    private int score = 0;

    //Total score text on the corner
    public Text scoreText;

    public Animator gameOverAnim;

<<<<<<< HEAD
    public Animator finishTaskAnim;

=======
<<<<<<< HEAD
    public Animator finishTaskAnim;

=======
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    //Menu score text
    //public Text lastScoreText;
    //public Text bestText;

    public Text newHighScore;

    //menu background
    public Image background;

    //This array contains all the text in the menu
    public Text[] scoreTexts;

    //LayerMask decide what the ground is for the player
    public LayerMask whatIsGround;
    //indicates if the play is playing the game
    private bool isPlaying = false;
    //reference to the contact point
    public Transform contactPoint;


    //Audio Collider
    public AudioSource tickSource;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    //delay before loading the another scene
    [SerializeField]
    private float delayBeforeLoading;
    //the name set for loaded scene
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed;


    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
=======
=======

    // Use this for initialization
    void Start () {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
        isDead = false;
        //before click, the ball stay still on the screen
        dir = Vector3.zero;

        tickSource = GetComponent<AudioSource>();

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    }

    // Update is called once per frame
    void Update()
    {

        if (!IsGrounded() && isPlaying)
        {
<<<<<<< HEAD
=======
=======
	}
	
	// Update is called once per frame
	void Update () {

        if (!IsGrounded() && isPlaying) {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
            //kill player
            isDead = true;

            GameOver();

            //reload the level in TileManger
            resetBtn.SetActive(true);
            //make camero not follow the player anymore
            if (transform.childCount > 0)
            {
                transform.GetChild(0).transform.parent = null;
            }
        }

        //CHANGING DIRECTION
        //GetMouseButtonDown works for louse click and phone touch
        //isDead: if player dead we can't change the direction anymore
<<<<<<< HEAD
        if (Input.GetKeyDown("space") && !isDead)
        {
=======
<<<<<<< HEAD
        if (Input.GetKeyDown("space") && !isDead)
        {
=======
        if (Input.GetKeyDown("space") && !isDead) {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407

            isPlaying = true;

            //When we click the button, the score +1
            score++;
            scoreText.text = score.ToString();
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
            
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
            //If the player moving forward, for next click the player moving left
            if (dir == Vector3.forward)
            {
                dir = Vector3.left;
            }
<<<<<<< HEAD
            else
            {
=======
<<<<<<< HEAD
            else
            {
=======
            else {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
                dir = Vector3.forward;
            }
        }

        //Calculate how much we need to move every time the update is called
        float amoutToMove = speed * Time.deltaTime;

        //transform: access the transform component; Translate function to move
        transform.Translate(dir * amoutToMove);

<<<<<<< HEAD
        if (score >= 50)
=======
<<<<<<< HEAD
        if (score >= 30)
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
        {
            //Make the payer to stop
            speed = 0;
            //Show task complete nots
            finishTaskAnim.SetTrigger("FinishTask");
            //spend time
            timeElapsed += Time.deltaTime;

            if (timeElapsed > delayBeforeLoading)
            {
                Application.LoadLevel(sceneNameToLoad);
            }
        }
    }
<<<<<<< HEAD
=======
=======
	}
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407

    //Pickup the pickup object
    private void OnTriggerEnter(Collider other)
    {
        //RED Mushroom increase score
<<<<<<< HEAD
        if (other.tag == "Pickup1")
        {
=======
<<<<<<< HEAD
        if (other.tag == "Pickup1")
        {
=======
        if (other.tag == "Pickup1") {
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
            //hide the pickup object
            other.gameObject.SetActive(false);
            //Instantiate the particle system
            Instantiate(ps, transform.position, Quaternion.identity);
<<<<<<< HEAD
            score += 3;
=======
<<<<<<< HEAD
            score += 3;
=======
            score+= 3;
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
            scoreText.text = score.ToString();
            CombatTextManager.Instance.CreateText(other.transform.position, "+3", Color.green, true);
            //Add sound when touch the object
            tickSource.Play();
        }

        //YELLOW Mushroom decrease score
        if (other.tag == "Pickup2")
        {
            //hide the pickup object
            other.gameObject.SetActive(false);
            //Instantiate the particle system
            Instantiate(ps, transform.position, Quaternion.identity);
            score -= 2;
            scoreText.text = score.ToString();
            CombatTextManager.Instance.CreateText(other.transform.position, "-2", Color.red, true);
            //Add sound when touch the object
            tickSource.Play();
        }
    }

    private void GameOver()
    {
        //trigger the menu animation
        gameOverAnim.SetTrigger("GameOver");

        scoreTexts[1].text = score.ToString();

        //playerprefs is a way of saving something and loading something in the memory in unity
        //default value is 0
<<<<<<< HEAD
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
=======
<<<<<<< HEAD
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
=======
        int bestScore = PlayerPrefs.GetInt("BestScore",0);
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            newHighScore.gameObject.SetActive(true);
<<<<<<< HEAD
            background.color = new Color32(227, 135, 46, 255);
=======
<<<<<<< HEAD
            background.color = new Color32(227, 135, 46, 255);
=======
            background.color = new Color32(227,135,46,255);
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407

            foreach (Text txt in scoreTexts)
            {
                txt.color = Color.yellow;
            }
        }

        //ele3 in the arraylist
        scoreTexts[3].text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }

    //if the player is hitting the ground or not
    private bool IsGrounded()
    {
        //contactPoint is the start of the sphere
        Collider[] colliders = Physics.OverlapSphere(contactPoint.position, 0.5f, whatIsGround);

        for (int i = 0; i < colliders.Length; i++)
        {
            //object on the ground
            if (colliders[i].gameObject != gameObject)
            {
                return true;
            }
        }

        return false;
    }
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> 5634003b430d2f366afef1a5d6109ebcbb4c48f9
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
}

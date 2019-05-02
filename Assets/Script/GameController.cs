using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [SerializeField]
    private Sprite bgImage;
    //Get all animal puzzles' sprites
    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public List<Button> btns = new List<Button>();

    private bool firstGuess, secondGuess;

    private int countGuesses, countcorrctGuessses, gameGuesses;
    //get button int name/number
    private int firstGuessIndex, secondGuessIndex;
    //use to compare two images
    private string firstGuessPuzzle, secondGuessPuzzle;

    void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        Shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
    }

    void GetButtons() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleBtn");

        for (int i = 0; i < objects.Length; i++) {
            btns.Add(objects[i].GetComponent<Button>());
            //use the same index to access the same button that we add from code before
            btns[i].image.sprite = bgImage;
        }
    }

    void AddListeners() {
        foreach (Button btn in btns) {
            //add our listener to our buttons
            btn.onClick.AddListener(() => PickButton());
        }
    }

    void AddGamePuzzles() {
        //number of buttons
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++) {
            //the sprite of two buttons should be same (looper/2)
            if (index == looper / 2) {
                //in order to add the same buttons again in the gamePuzzles list
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }

    public void PickButton() {

        if (!firstGuess){
            firstGuess = true;
            //Parse return a string, convert a string to an integer
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            //get the name of our image, and then compare our names in order to check if our puzzles match
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }
        else if (!secondGuess) {
            secondGuess = true;
            //Parse return a string, convert a string to an integer
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;

            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            countGuesses++;

            StartCoroutine(CheckIfPuzzleMatch());
        }
    }

    IEnumerator CheckIfPuzzleMatch() {
        yield return new WaitForSeconds(1f);

        if (firstGuessPuzzle == secondGuessPuzzle)
        {
            yield return new WaitForSeconds(.5f);

            //disable the button if we guess correctly
            btns[firstGuessIndex].interactable = false;
            btns[secondGuessIndex].interactable = false;

            //invisible the matched buttons (Alpha Channel)
            btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

            CheckIfGameFinished();
        }
        else {

            yield return new WaitForSeconds(.5f);

            //if not guess the puzzle correctly, back to the background image
            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;
        }

        yield return new WaitForSeconds(.5f);

        firstGuess = secondGuess = false;
    }

    void CheckIfGameFinished() {
        countcorrctGuessses++;

        if (countcorrctGuessses == gameGuesses) {
            Debug.Log("Game Finished");
            Debug.Log("It took you "+ countGuesses + " many guess(es) to finish the game.");
        }
    }

    //Randum the sprite image (button image)
    void Shuffle(List<Sprite> list) {
        for (int i = 0; i < list.Count; i++) {
            Sprite temp = list[i];
            int randomIndex = Random.Range(0, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}

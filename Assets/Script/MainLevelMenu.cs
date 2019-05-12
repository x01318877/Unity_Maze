using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLevelMenu : MonoBehaviour {

    //squareEasy
    public void LoadsquareEasy()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //squareMedium
    public void LoadsquareMedium()
    {
        Time.timeScale = 1f;
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    }

    //squareHard
    public void LoadsquareHard()
    {
        Time.timeScale = 1f;
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    }

    //roundEasy
    public void roundEasy()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    //roundmedium
    public void roundmedium()
    {
        Time.timeScale = 1f;
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    }

    //roundhard
    public void roundhard()
    {
        Time.timeScale = 1f;
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
>>>>>>> 7ed656a146c63ed5505a1ba04ac5d6e7b1a0e407
    }

    //Random
    public void random()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
}

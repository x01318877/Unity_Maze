using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        //stop pause
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        //enable it
        pauseMenuUI.SetActive(true);
        //freese time
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //squareEasy
    public void LoadMenu1()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //squareMedium
    public void LoadMenu2()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //squareHard
    public void LoadMenu3()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    //roundEasy
    public void LoadMenu4()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    //roundmedium
    public void LoadMenu5()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    //roundhard
    public void LoadMenu6()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    //random
    public void LoadMenu7()
    {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubPauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();
            }
        }
	}

    public void Resume() {
        pauseMenuUI.SetActive(false);
        //stop pause
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        //enable it
        pauseMenuUI.SetActive(true);
        //freese time
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() {
        //stop pause
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

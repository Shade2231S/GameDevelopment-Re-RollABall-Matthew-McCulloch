using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework;

public class Restart : MonoBehaviour
{
    public GameObject pause;
    public static bool isPaused;
    public GameObject player;
    public GameObject restart;
    public GameObject pausetext;
    public GameObject quit;
    void Start()
    {
        PlayerController playerController = player.GetComponent<PlayerController>();
        isPaused = false;
        pause.SetActive(false);
        restart.gameObject.SetActive(false);
        pausetext.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        restart.gameObject.SetActive(true);
        pausetext.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
    }
    public void Resume() 
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        restart.gameObject.SetActive(false);
        pausetext.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }
    public void RestartFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuittoMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}

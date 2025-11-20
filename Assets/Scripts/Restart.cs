using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework;

public class Restart : MonoBehaviour
{
    public GameObject pausemenu;
    public static bool isPaused;
    public GameObject player;
    public GameObject restartbutton;
    public GameObject pausetext;
    public GameObject quittomenu;
    void Start()
    {
        PlayerController playerController = player.GetComponent<PlayerController>();
        isPaused = false;
        pausemenu.SetActive(false);
        restartbutton.gameObject.SetActive(false);
        pausetext.gameObject.SetActive(false);
        quittomenu.gameObject.SetActive(false);
    }

    public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        restartbutton.gameObject.SetActive(true);
        pausetext.gameObject.SetActive(true);
        quittomenu.gameObject.SetActive(true);
    }
    public void Resume() 
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        restartbutton.gameObject.SetActive(false);
        pausetext.gameObject.SetActive(false);
        quittomenu.gameObject.SetActive(false);
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

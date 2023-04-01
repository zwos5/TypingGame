using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public Text pausedText;
    public Button quitGame;
    public Text currentWords;
    public Text totalWords;
    public Button resume;


    void Start()
    {
        totalWords.text = WordDisplay.wordTotal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // escape key pauses AND resumes
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        pausedText.gameObject.SetActive(true); 
        quitGame.gameObject.SetActive(true);
        currentWords.gameObject.SetActive(true);
        totalWords.gameObject.SetActive(true);
        resume.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        pausedText.gameObject.SetActive(false);
        quitGame.gameObject.SetActive(false);
        currentWords.gameObject.SetActive(false);
        totalWords.gameObject.SetActive(false);
        resume.gameObject.SetActive(false);
    }
}
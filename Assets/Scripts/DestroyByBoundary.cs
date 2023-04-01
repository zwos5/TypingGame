using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByBoundary : MonoBehaviour
{
    public Canvas canvas;
    public WordManager manager;
    private float minYPosition = -6.08f; //Y position of the game over trigger

    void Update()
    {
        for(int i = 0; i < manager.words.Count; i++) //Checks each word on the screen
        {
            Word word = manager.words[i];
            RectTransform rectTransform = word.display.text.GetComponent<RectTransform>();
            if(rectTransform.anchoredPosition.y < minYPosition) //If the word falls below the trigger's Y-Position
            {
                manager.RemoveWord(word);
                Destroy(word.display.gameObject);
                i--;
                //SceneManager.LoadScene("Exit"); Exit scene loads after the user has a word exit the screen
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitTotals : MonoBehaviour
{
    public Text totalWords;
    public Text totalChars;
    public Text correctCharacters;
    public Text percentCorrect;

    public float correctChars = 0;
    public float characters = 0;
    public float percentage = 0; 

    void Start() {
        correctChars = WordManager.correctChars;
        characters = WordManager.charTotal;
        totalWords.text = WordManager.wordTotal.ToString();
        totalChars.text = WordManager.charTotal.ToString();
        correctCharacters.text = WordManager.correctChars.ToString();
        percentage = (correctChars / characters) * 100;
        percentCorrect.text = percentage.ToString("f2");
    }
}

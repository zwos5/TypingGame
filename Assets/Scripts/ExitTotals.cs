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

    public void Awake() {
        totalWords.text = KeepData.a.ToString();
        totalChars.text = KeepData.b.ToString();
        correctCharacters.text = KeepData.d.ToString();
        percentCorrect.text = KeepData.c.ToString();
    }
}

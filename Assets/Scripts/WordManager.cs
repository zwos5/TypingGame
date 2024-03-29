using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public static int wordTotal;
	public static int charTotal;
	public static int correctChars;
	//public static float percentage = correctChars / charTotal;

	void Start()
    {
		wordTotal = 0;
		charTotal = 1;
		correctChars = 0;
	}

	public void AddWord()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
		wordTotal++;
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
				correctChars++;
				charTotal++;
			}
			else
            {
				charTotal++;
            }
		}
		else
		{
			foreach (Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					charTotal++;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}
		
	}

	public void RemoveWord(Word wordToRemove)
    {
		if(hasActiveWord && activeWord == wordToRemove)
        {
			hasActiveWord = false;
        }
		words.Remove(wordToRemove);
    }

}
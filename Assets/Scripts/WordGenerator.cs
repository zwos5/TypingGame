using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{
    //private static string[] wordList = {   "sidewalk", "robin", "three", "protect", "periodic",
    //                                "somber", "majestic", "jump", "pretty", "wound", "jazzy",
    //                                "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
    //                                "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
    //                                "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
    //                                "guide", "long", "chief", "mom", "signal", "rely", "abortive",
    //                                "hair", "representative", "earth", "grate", "proud", "feel",
    //                                "hilarious", "addition", "silent", "play", "floor", "numerous",
    //                                "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
    //                                "mellow", "analyse", "crate", "homely", "protest", "painstaking",
    //                                "society", "head", "female", "eager", "heap", "dramatic", "present",
    //                                "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
    //                                "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
    //                                "account", "spot", "thought", "distinct", "nimble", "practise", "cream",
    //                                "ablaze", "thoughtless", "love", "verdict", "giant"    };

    private static string[] wordList = { };

    void Start()
    {
        Invoke("RandomWordGenerator", 0f);
    }

    public void RandomWordGenerator()
    {
        string path = "Assets/words.txt";
        string listContent = File.ReadAllText(path);
        wordList = listContent.Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
    }

    public static string GetRandomWord()
	{
		int randomIndex = Random.Range(0, 999);
		string randomWord = wordList[randomIndex];
        return randomWord;
        
	}
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DoanSo : MonoBehaviour
{
    int max = 1000, min = 0;
    int guess;
    public TextMeshProUGUI guessText;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    //Ham chay game
    void StartGame()
    {
        max = 1000;
        min = 0;
        NextGame();
    }
    //Ham cap nhat lai tinh huong sau khi nhan phim
    public void NextGame()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
    // Update is called once per frame
    public void GuessHigh()
    {
       min = guess; // gan min = 500
       NextGame();
    }
    public void GuessLower()
    {
        max = guess;
        NextGame();
    }
}

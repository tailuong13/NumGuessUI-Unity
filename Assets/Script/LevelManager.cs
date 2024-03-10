using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel (string name) 
    {
        Debug.Log("Level hien tai la: " + name);
        Application.LoadLevel("Game");
    }
    public void Quit()
    {
        Debug.Log("Toi muon thoat game");
        Application.Quit();
    }
    public void Win()
    {
        Debug.Log("Toi da doan dung!!!");
        Application.LoadLevel("WinScene");
    }
    public void PlayAgain()
    {
        Debug.Log("Toi muon choi lai");
        Application.LoadLevel("StartMenu");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    InputField nameTxt;
    [SerializeField]
    Text bestScoreTxt;
    public string name;
    public int bestScore = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        LoadPrefs();
    }
    void Start()
    {

    }
    public void GetNameFromInputField()
    {
        name = nameTxt.text;
        bestScore = ChangeBestScore(0);
        bestScoreTxt.text = "BEST SCORE: " + name.ToUpper() + " | " + bestScore;
    }
    public int ChangeBestScore(int newScore)
    {
        int score;
        if (bestScore < newScore)
        {
            score = newScore;
        }
        else { score = bestScore; }
        return score;
    }
    public int BestScore()
    {
        return bestScore;
    }
    public string NameSend()
    {
        return name;
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("main");
    }
    public void ExitAplication()
    {
        Application.Quit();
    }
    public void SavePrefs(int bs, string nm)
    {
        PlayerPrefs.SetInt("bestScore", bs);
        PlayerPrefs.SetString("name", nm);
        PlayerPrefs.Save();
    }

    public void LoadPrefs()
    {
        bestScore = PlayerPrefs.GetInt("bestScore", bestScore);
        name = PlayerPrefs.GetString("name", name);
    }
}

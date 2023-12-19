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

    public string name;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {

    }
    public void GetNameFromInputField()
    {
        name = nameTxt.text;
        Debug.Log(name);
    }
    void Update()
    {

    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("main", LoadSceneMode.Additive);
    }
    public void ExitAplication()
    {
        Application.Quit();
    }
}

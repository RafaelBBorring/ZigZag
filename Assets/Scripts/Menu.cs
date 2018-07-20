using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    GameManager gManager;

    // Use this for initialization
    void Start()
    {
        gManager = GameManager.gManager;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BT_Play()
    {
        SceneManager.LoadScene("Jogo 1");
        gManager.Score = 0;

    }

    public void BT_Custom()
    {
        SceneManager.LoadScene("CustomMain");

    }

    public void BT_About()
    {
        SceneManager.LoadScene("About");
    }

    public void BT_Exit()
    {
        Application.Quit();
    }
    public void BT_Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
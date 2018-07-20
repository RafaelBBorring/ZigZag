using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BT_Play()
    {
        SceneManager.LoadScene("Jogo");
        
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
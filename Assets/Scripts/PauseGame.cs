using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{



    [SerializeField]
    private Text txtPause;

    public void Pausa()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            txtPause.enabled = true; 
        }
        else
        {
            Time.timeScale = 1;
            txtPause.enabled = false;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    public int Score = 0;
    [SerializeField]
    public int Moedas;
    [SerializeField]
    private Text MoedasTxT;


    public static GameManager gManager;

    // Use this for initialization
    void Awake()
    {

        if (gManager == null)
        {
            gManager = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        MoedasTxT.text = Moedas.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

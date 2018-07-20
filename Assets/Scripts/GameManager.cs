using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField]
    public int Score = 0;


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

    }

    // Update is called once per frame
    void Update()
    {

    }
}

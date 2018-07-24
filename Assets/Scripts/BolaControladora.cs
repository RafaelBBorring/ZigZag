using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolaControladora : MonoBehaviour {


    [SerializeField]
    private float vel = 0.5f,limiteVel = 2.5f;
    [SerializeField]
    private Rigidbody rb;
    public static bool gameOver = false;
    [SerializeField]
    private int moedasNum;
    [SerializeField]
    private int pontosNum = 0;
    [SerializeField]
    private Text txtMoedas;
    [SerializeField]
    private Text txtPontos;
  

    GameManager gManager;

    


	// Use this for initialization
	void Start () {
        gameOver = false;

        

        rb = GetComponent<Rigidbody>();

        
        rb.velocity = new Vector3(vel, 0, 0);

        gManager = GameManager.gManager;

        pontosNum = gManager.Score;
        moedasNum = gManager.Moedas;

       
        

        StartCoroutine(AjustaVel());
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)&& !gameOver)
        {
            BolaMov();


        }
        if (!Physics.Raycast(transform.position, Vector3.down, 1))
        {

            gameOver = true;

            rb.useGravity = true;

            if (gameOver == true)
            {
                SceneManager.LoadScene("GameOver");
                
            }
            
        }
        


      
    }

    void BolaMov()
    {
        if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, vel);
            gManager.Score++;
            txtPontos.text = gManager.Score.ToString();
            
        }
        else if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(vel, 0, 0);
            gManager.Score++;
            txtPontos.text = gManager.Score.ToString();
            
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("moeda"))
        {
            Destroy(col.gameObject);
            gManager.Moedas++;
            txtMoedas.text = gManager.Moedas.ToString();

        }
    }

    IEnumerator AjustaVel()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(2);
            if (vel <= limiteVel)
            {
                vel += 0.2f;
            }
            
        }
    }
}

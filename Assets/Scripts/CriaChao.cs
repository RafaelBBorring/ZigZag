using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaChao : MonoBehaviour
{

    [SerializeField]
    private GameObject chao,moeda;
    [SerializeField]
    private float TamanhoXZ;
    [SerializeField]
    private Vector3 posUltima;

    // Use this for initialization
    void Start()
    {
        posUltima = chao.transform.position;
        TamanhoXZ = chao.transform.localScale.x;

        for (int i = 0; i < 10; i++)
        {
            CriaChaoXZ();
        }

        StartCoroutine(CriaChaoInGame());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CriaX()
    {
        Vector3 tempPos = posUltima;
        tempPos.x += TamanhoXZ;
        posUltima = tempPos;
        Instantiate(chao, tempPos, Quaternion.identity);

        int rand = Random.Range(0,5);

        if (rand <= 1)
        {
            Instantiate(moeda, new Vector3(tempPos.x, tempPos.y + 0.2f, tempPos.z), moeda.transform.rotation);
        }
        
    }

    void CriaZ()
    {
        Vector3 temPos = posUltima;
        temPos.z += TamanhoXZ;
        posUltima = temPos;
        Instantiate(chao, temPos, Quaternion.identity);

        int rand = Random.Range(0,5);

        if(rand <= 1)
        {
            Instantiate(moeda, new Vector3(temPos.x, temPos.y + 0.2f, temPos.z), moeda.transform.rotation);
        }

    }

    void CriaChaoXZ()
    {
        int temp = Random.Range(0,7);

       
        
            if (temp < 3)
            {
                CriaX();
               
            }
            else if (temp >= 3)
            {
                CriaZ();
                
            }
        
    }

    IEnumerator CriaChaoInGame()
    {
        while (BolaControladora.gameOver != true)
        {
            yield return new WaitForSeconds (0.5f);
            CriaChaoXZ();


        }
    }
}

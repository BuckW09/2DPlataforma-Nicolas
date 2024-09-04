using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Conf Gerador1")]
    public GameObject inimigo1;

    public float temporizador;
    public int tempoDelay;
    public bool GameOver = false;

    [Header("Conf Gerador2")]

    public GameObject inimigo2;
    public Transform posSpawn1;
    public Transform posSpawn2;


    [Header("Conf Gerador3")]
    public GameObject inimigo3;




    void Start()
    {
        temporizador = Time.time + tempoDelay;
        StartCoroutine(timeIni2());
    }

    // Update is called once per frame
    void Update()
    {
        GeradorInimigo1();
    }
    public void GeradorInimigo1()
    {
        if (temporizador <= Time.time && GameOver == false)
        {
            Instantiate(inimigo1,transform.position,Quaternion.identity);
            temporizador = Time.time + tempoDelay;
        }
    }

    public void GeradorInimigo2()
    {
        Instantiate(inimigo2, posSpawn1.position, Quaternion.identity);
        
    }

    public void GeradorInimigo3()
    {
        Instantiate(inimigo3, posSpawn2.position, Quaternion.identity);

    }


    IEnumerator timeIni2(int tempo = 2)
    {

        
        yield return new WaitForSeconds(tempo);
        GeradorInimigo2();
        StartCoroutine(timeIni2());
        
    }
}

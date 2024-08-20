using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float temporizador;
    public int tempoDelay;
    public bool GameOver = false;
    // Start is called before the first frame update
    public GameObject inimigo1;
    void Start()
    {
        temporizador = Time.time + tempoDelay;
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
}

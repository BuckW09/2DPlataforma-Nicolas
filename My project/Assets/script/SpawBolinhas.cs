using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawBolinhas : MonoBehaviour
{
    public GameObject bolinhas;
    public Transform posicaoBolinhas;
    public float velocidadeBolinhas;
    void Start()
    {
        
    }

    // Update is called once per frame

    public void instanciarBolinhas()
    {
        Instantiate(bolinhas, posicaoBolinhas.transform.position, Quaternion.identity);
    }

}

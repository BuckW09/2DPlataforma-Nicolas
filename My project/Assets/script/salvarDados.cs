using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salvarDados : MonoBehaviour
{
    private movbasica _movimentoBasico;
    public int municaoAtual;
    public int vidaAtual;
    // Start is called before the first frame update
    void Start()
    {
        _movimentoBasico = FindObjectOfType(typeof(movbasica)) as movbasica;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        municaoAtual = _movimentoBasico.municaoAtual;
        vidaAtual = _movimentoBasico.vidaAtual;
    }
}

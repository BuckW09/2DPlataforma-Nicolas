using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movbasica : MonoBehaviour
{
    [Header("Conf Player")]
    public float velocidade;
    public float movimentoHorizontal;
    private Rigidbody2D rbPlayer;
    public float forcaPulo;
    public Transform posicaoSensor;
    public bool sensor;

    private Animator anim;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movimentoHorizontal = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(movimentoHorizontal * velocidade, rbPlayer.velocity.y);

        if (Input.GetButtonDown("Jump") && sensor == true)
        {
            rbPlayer.AddForce(new Vector2(0, forcaPulo));
        }
        anim.SetInteger("Run",(int)movimentoHorizontal);
    }


    public void verificarChao()
    {
        sensor = Physics2D.OverlapCircle(posicaoSensor.position, 0.34f);
    }
}
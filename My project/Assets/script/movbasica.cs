using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class movbasica : MonoBehaviour
{
  

    [Header("Conf Player")]
    public float velocidade;
    public float movimentoHorizontal;
    private Rigidbody2D rbPlayer;
    public float forcaPulo;
    public Transform posicaoSensor;
    public bool sensor;
    public Transform posiPlay;

    private Animator anim;
    public bool verificarDirecaoPersonagem;

    [Header("Conf Tiro")]
    public GameObject municao;
    public Transform posicTiro;
    public float velocidadeTiro;
    public LayerMask chao;

    [Header("Conf Vida")]
    public int contadordevida;
    public int vidaAtual;
    public TextMeshProUGUI textVida;

    [Header("Config Municao")]
    public int municaoAtual= 5;
    public TextMeshProUGUI textMunicao;

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        vidaAtual = 10;
        textVida.text = vidaAtual.ToString();

        municaoAtual = 10;
        textMunicao.text = municaoAtual.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -20)
        {
            //tra
        }
        verificarChao();
        movimentoHorizontal = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(movimentoHorizontal * velocidade, rbPlayer.velocity.y);

        if(movimentoHorizontal >0 && verificarDirecaoPersonagem == true)
        {
            Flip();
        }
        if (movimentoHorizontal < 0 && verificarDirecaoPersonagem == false)
        {
            Flip();
        }


        if (Input.GetButtonDown("Jump") && sensor == true)
        {
            rbPlayer.AddForce(new Vector2(0, forcaPulo));
        }
        if(Input.GetMouseButtonDown(0))
        {
            Atirar();
            anim.SetTrigger("shoot");

        }
        anim.SetInteger("Run",(int)movimentoHorizontal);
        anim.SetBool("sensor",sensor);

    }


    public void verificarChao()
    {
        sensor = Physics2D.OverlapCircle(posicaoSensor.position, 0.25f,chao);
    }

    public void Flip()
    {
        verificarDirecaoPersonagem = !verificarDirecaoPersonagem;
        float x = transform.localScale.x * -1;
        transform.localScale = new Vector3(x, transform.localScale.y,transform.localScale.z);
        velocidadeTiro *= -1;
        municao.GetComponent<SpriteRenderer>().flipX = verificarDirecaoPersonagem;
    }
    public void Atirar()
    {
        if(municaoAtual!= 0)
        {
            municaoAtual--;
            textMunicao.text = municaoAtual.ToString();
            GameObject temporario = Instantiate(municao);
            temporario.transform.position = posicTiro.position;
            temporario.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeTiro, 0);
        }
        else
        {
            municaoAtual = 0;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ganha vida
        if(collision.gameObject.tag == "vida")
        {
            contadordevida++;
            vidaAtual = vidaAtual + contadordevida;
            textVida.text = vidaAtual.ToString();
            Destroy(collision.gameObject);
        }
        //perder vida
        if(collision.gameObject.tag == "inimigo")
        {
            vidaAtual--;
            textVida.text = vidaAtual.ToString();
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "recarregar")
        {
            municaoAtual = municaoAtual + 5;
            textMunicao.text = municaoAtual.ToString();
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "mudarfase")
        {
            SceneManager.LoadScene("fase1");
        }
    }
}
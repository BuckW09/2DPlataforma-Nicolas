using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoPlataforma : MonoBehaviour
{
    // script do inimigo q fica na plataforma
    public Rigidbody2D rB;
    public float speedI3;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(-speedI3, rB.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "paredeTrigger")
        {
            rB.velocity = new Vector2(speedI3!, rB.position.y);
        }
    }
}

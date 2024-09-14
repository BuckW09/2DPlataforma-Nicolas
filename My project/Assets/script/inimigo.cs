using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Transform posPlayer;
    public float speedI2;
    public Rigidbody2D rB;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(posPlayer.position.x >= transform.position.x)
        {
            rB.velocity = new Vector2(-speedI2, rB.position.y);
        }

        if (posPlayer.position.x <= transform.position.x)
        {
            rB.velocity = new Vector2(speedI2, rB.position.y);
        }
    }
   
}

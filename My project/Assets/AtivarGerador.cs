using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarGerador : MonoBehaviour
{
    private GameManager gM;

    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ParedeInvisivelAtivar")
        {
            gM.GeradorInimigo3();
        }
    }

    
}

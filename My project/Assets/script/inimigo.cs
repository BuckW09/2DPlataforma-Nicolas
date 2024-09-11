using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Transform posPlayer;
    public int speedI2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(posPlayer.position.x >= transform.position.x)
        {
            
        }
    }
   
}

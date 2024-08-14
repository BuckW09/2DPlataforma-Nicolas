using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IrJogar()
    {
        SceneManager.LoadScene(1);
    } 
    public void Sair()
    {
        Application.Quit();
    }
}

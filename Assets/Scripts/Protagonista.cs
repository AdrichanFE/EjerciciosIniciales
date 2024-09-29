using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonista : MonoBehaviour
{

    float vida;
    float exp;
    string nombre;

    public float Vida { get => vida; set => vida = value; }
    public float Exp { get => exp; set => exp = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float CalcularNivel()
    {
      return exp / 1000;
      
    }
    
}

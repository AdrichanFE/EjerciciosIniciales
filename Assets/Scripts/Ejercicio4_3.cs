using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float valorEuro = 0.9f, valorDollar = 1.12f, conversor = 0;
    string moneda;
    // Start is called before the first frame update
    void Start()
    {
        Convertir(3,"Euro");
        Convertir(7,"Dollar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(int cantidad,string moneda)
    {
        

        if (moneda == "Euro")
        {
            conversor = cantidad * valorDollar;
            Debug.Log("Esta cantidad de euros son " + conversor + " dolares.");
        }
        else if (moneda == "Dollar")
        {
            conversor=cantidad * valorEuro;
            Debug.Log("Esta cantidad de dolares son " + conversor + " euros.");
        }
        else
        {
            Debug.Log("Error, introduzca moneda valida");
        }
        return conversor;
    }
}

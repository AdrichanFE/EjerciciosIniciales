using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 35.45f,resultadoMultiplicacion,resultadoDivision,resultadoDoble,resultadoTriple;
    // Start is called before the first frame update
    void Start()
    {
        resultadoMultiplicacion=vidas*exp;
        Debug.Log(resultadoMultiplicacion);
        resultadoDivision=vidas/exp;
        Debug.Log(resultadoDivision);
        resultadoDoble = vidas *= 2;
        Debug.Log(resultadoDoble);
        resultadoTriple = exp *= 3;
        Debug.Log(resultadoTriple);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

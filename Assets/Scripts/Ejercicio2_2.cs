using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas=5;
    float exp=54.36f,resultadoSuma,resultadoResta;
    char carac='A';
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);
        resultadoSuma=vidas+exp;
        resultadoResta=exp-vidas;

        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{

    float areaCirculo, areaTriangulo, areaCuadrado;
    float radio = 12, bse = 24, altura = 36, lado = 16;
    float valorEuro = 0.9f, valorDollar = 1.12f, conversor = 0;
    string moneda;
    // Start is called before the first frame update
    void Start()
    {
        AreaDelCirculo();
        float nombreNuevo = AreaDelCirculo();
        AreaDelCuadrado();
        AreaDelTriangulo();
        float suicidio = Convertir(nombreNuevo, "Dollar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float AreaDelCirculo()
    {
        areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;

    }
    float AreaDelTriangulo()
    {
        areaTriangulo = (bse * altura) / 2;
        return areaTriangulo;
    }
    float AreaDelCuadrado()
    {
        areaCuadrado = lado * lado;
        return areaCuadrado;
    }

    float Convertir(float resultadoCirculo, string moneda)
    {


        if (moneda == "Euro")
        {
            conversor = resultadoCirculo * valorDollar;
            Debug.Log("Esta cantidad de euros son " + conversor + " dolares.");
        }
        else if (moneda == "Dollar")
        {
            conversor = resultadoCirculo * valorEuro;
            Debug.Log("Esta cantidad de dolares son " + conversor + " euros.");
        }
        else
        {
            Debug.Log("Error, introduzca moneda valida");
        }
        return conversor;
    }
}

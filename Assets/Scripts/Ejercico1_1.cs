using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercico1_1 : MonoBehaviour
{
    //Declarar variables. Tipo, Nombre y Valor.
    //public int vida = 5;
    //public float porcentajeAcierto = 3.45f;
    //public bool quemado = true;
    //string explorador = "Iñigo Montoya";
    //char solucionPuzzle = 'A';
    


    void Start()
    {
        //vida = 5; //Asignar el valor a una variable.
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer juego de Adrian(el Abuelo)");
        Debug.Log("Estoy aprendiendo C#");
    }

    
    void Update()
    {
        Debug.Log("Ha pasado un frame"); //Este mensaje aparece muchas veces porque cada frame lo crea, no solo al inicio como en el start.
    }
}

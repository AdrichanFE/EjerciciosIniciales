using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero = 4;
    
    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;
        Debug.Log("El doble de su numero es: " + doble+ ", y el triple de su numero es: "+triple+", ¿Cual es su numero?");
       
    }

    
    void Update()
    {
        
    }
}

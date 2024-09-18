using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Pepe", apellido1 = "Rodríguez", apellido2 = "Jiménez";
    int edad = 20;
    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ConstruirNombre()
    {
        Debug.Log("Los datos de esta persona son: " + nombre + " " + apellido1 + " " + apellido2 + " " + edad+ "años");
    }
}

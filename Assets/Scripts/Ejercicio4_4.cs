using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        ConversorKmH(135.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float ConversorKmH(float velocidad)
    {
        float velocidadMS = velocidad / 3.6f;
        Debug.Log("La velocidad en m/s es: " + velocidadMS);
        return velocidadMS;
    }
}

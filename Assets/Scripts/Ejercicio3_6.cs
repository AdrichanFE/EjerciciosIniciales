using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidad1, velocidad2;
    float nuevaVelocidad1, nuevaVelocidad2;
    // Start is called before the first frame update
    void Start()
    {
        nuevaVelocidad1 = velocidad1 / 3.6f;
        Debug.Log("La velocidad del coche 1 a pasado a: " + nuevaVelocidad1 + ", m/s");
        nuevaVelocidad2 = velocidad2 / 3.6f;
        Debug.Log("La velocidad del coche 2 a pasado a: " + nuevaVelocidad2 + ", m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

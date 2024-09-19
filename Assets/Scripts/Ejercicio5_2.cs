using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3)
        {
            Debug.Log("El numero es menor que 3");
        }
        else
        {
            Debug.Log("El numero es mayor que 3");
        }
        if (numero2 < 3)
        {
            Debug.Log("El numero es menor que 3");
        }
        else
        {
            Debug.Log("El numero es mayor que 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

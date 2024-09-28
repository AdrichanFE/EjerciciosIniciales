using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    //No se como realizar este ejercicio con lo que hemos aprendido, sin usar el Mathf.Min o Max
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        for (numero1 = 1; numero1 <= numero2; numero1++) //Esto me sirve para leer los numero pares, pero se va a saltar el resto
        {
            if (numero1 % 2 == 0)
            {
                Debug.Log(numero1);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

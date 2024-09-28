using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(NumeroPrimo(25));
        Debug.Log(NumeroPrimo(2));
        Debug.Log(NumeroPrimo(17));
        Debug.Log(NumeroPrimo(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //bool NumeroPrimo(int numero)
    //{
    //    if (numero <= 1) return false;

    //    for (int i = 2;i<=numero;i++)
    //    {
    //        if (numero % i == 0) return false;
    //    }
    //    return true;   
    //}

    bool NumeroPrimo(int numero)
    {
        if (numero <= 1) return false; // 0 y 1 no son primos
        if (numero == 2) return true; // 2 es el único número primo par

        for (int i = 3; i * i <= numero; i += 2) // i*i Es mas eficiene que ir hasta el numero de uno en uno, e incrementamos de 2 en 2 para saltarnos los numero pares y solo se comprueba la divisibilidad de los impares.
        {
            if (numero % i == 0) return false;
        }

        return true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < numero2)
        {
            for (numero1 = numero1; numero1 < numero2; numero1++)
            {
                Debug.Log(numero1);
            }
        }
        else if (numero2 < numero1)
        {
            for (numero2 = numero2; numero2 < numero1; numero2++)
            {
                Debug.Log(numero2);
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

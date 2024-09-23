using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero,numeroFor;
    // Start is called before the first frame update
    void Start()
    {
        //while (numero < 46)
        //{
        //    Debug.Log(numero);
        //    numero++;
        //}


        for (int i = 1; i < numeroFor; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

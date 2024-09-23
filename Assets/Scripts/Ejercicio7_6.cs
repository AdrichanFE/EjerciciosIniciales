using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero, numeroFor;
    // Start is called before the first frame update
    void Start()
    {
        //while (numero > -3)
        //{
        //    Debug.Log(numero);
        //    numero--;
        //}


        for (int i = 100; i > numeroFor; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

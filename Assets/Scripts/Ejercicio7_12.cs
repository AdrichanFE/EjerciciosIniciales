using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    int sumaAcumulada = 0;
    // Start is called before the first frame update
    void Start()
    {
        //SumarTodosLosNumeros(1,45);
        Debug.Log(SumarTodosLosNumeros(1,45));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumarTodosLosNumeros(int num1, int num2)
    {
        for (int i = num1; i <= num2; i++)
        {
            sumaAcumulada += i;     
        }
        return sumaAcumulada;
    }
}

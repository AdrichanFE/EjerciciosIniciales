using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int hora, minuto, segundo;
    // Start is called before the first frame update
    void Start()
    {
        Hora();
        Debug.Log("La hora actual es: " + hora + " " + minuto + " " + segundo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Hora()
    {
        if (hora < 0 && hora > 25)
        {
            Debug.Log("La hora es valida: " + hora);
        }
        else
        {
            Debug.Log("La hora es invalida");
        }
        if (minuto < 0 && minuto > 61)
        {
            Debug.Log("Los minutos son validos: " + minuto);
        }
        else
        {
            Debug.Log("Los minutos son invalidos");
        }
        if (segundo < 0 && segundo > 61)
        {
            Debug.Log("Los segundos son validos: " + segundo);
        }
        else
        {
            Debug.Log("Los segundos son invalidos");
        }
    }
}

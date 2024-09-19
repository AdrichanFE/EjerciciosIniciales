using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float numero1, numero2;
    float division;
    
    // Start is called before the first frame update
    void Start()
    {
         division = numero1 / numero2;
        if (division != 0 && division>0)
        { 
            Debug.Log("El resultado es: " + division);
        }
        else
        {
            Debug.Log("Eso no se puede dividir animal de bellota!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

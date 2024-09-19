using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >=0 && numero <= 9)
        {
            Debug.Log("El numero esta comprendido entre el 0 y el 9");
        }
        else
        {
            Debug.Log("El numero no esta comprendido entre 0 y 9, sorry");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

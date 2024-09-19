using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivelPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        if(nivelPersonaje %2==0)
        {
            Debug.Log("El numero es par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

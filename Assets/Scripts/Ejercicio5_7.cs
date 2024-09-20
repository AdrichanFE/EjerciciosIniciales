using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidadJ1;
    [SerializeField] int velocidadJ2;
    [SerializeField] int velocidadJ3;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidadJ1 > velocidadJ2 && velocidadJ1 > velocidadJ3)
        {
            Debug.Log("El jugador 1 ataca primero");
        }
        else if (velocidadJ2 > velocidadJ1 && velocidadJ2 > velocidadJ3)
        {
            Debug.Log("El jugador 2 ataca primero");
        }
        else if(velocidadJ3>velocidadJ1&& velocidadJ3 > velocidadJ2)
        {
            Debug.Log("El jugador 3 ataca primero");
        }
        else
        {
            Debug.Log("Varios personajes tienen la misma velocidad, asi que toca duelo de baile");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

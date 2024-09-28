using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {

            for (numero1 = 1; numero1 <= numero2; numero1++)
            {
                if (numero1 % 2 == 0)
                {
                Debug.Log(numero1);
                }
                
            }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

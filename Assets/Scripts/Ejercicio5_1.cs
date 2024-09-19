using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1, vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("La batalla esta muy reñida, parecen fuegos de artificio");
        }
        else
        {
            Debug.Log("La batalla se desarrolla normal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

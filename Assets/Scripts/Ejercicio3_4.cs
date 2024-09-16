using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float exp;
    float lvl;
    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log("Su nivel es: " + lvl);
    }

    
    void Update()
    {
        
    }
}

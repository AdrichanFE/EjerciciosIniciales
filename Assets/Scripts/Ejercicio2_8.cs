using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120;
    float daño = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        float nuevaVida = vidaInicial * daño;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

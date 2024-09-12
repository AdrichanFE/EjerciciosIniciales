using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 123;
    int puntuacion2 = 231;
    int puntuacion3 = 312;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntuacion 1: " + puntuacion1 + " Puntuacion 2: " + puntuacion2 + " Puntuacion 3: " + puntuacion3);

        int resultado= puntuacion1 + puntuacion2 + puntuacion3;
        int media = resultado / 3;
        Debug.Log("Media: "+media);

    }
}

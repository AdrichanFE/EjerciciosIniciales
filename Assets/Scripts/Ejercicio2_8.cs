using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120;
    float da�o1 = 0.03f,da�o2=0.06f,da�o3=0.09f,da�o4=0.12f,da�o5=0.15f;
    // Start is called before the first frame update
    void Start()
    {
        float da�oRecibido1 = vidaInicial * da�o1;
        float da�oRecibido2 = vidaInicial * da�o2;
        float da�oRecibido3 = vidaInicial * da�o3;
        float da�oRecibido4 = vidaInicial * da�o4;
        float da�oRecibido5 = vidaInicial * da�o5;
        float vidaActual1 = vidaInicial - da�oRecibido1;
        float vidaActual2 = vidaInicial - da�oRecibido2;
        float vidaActual3 = vidaInicial - da�oRecibido3;
        float vidaActual4 = vidaInicial - da�oRecibido4;
        float vidaActual5 = vidaInicial - da�oRecibido5;
        Debug.Log("Has recibido un 3% da�o, tu vida actual es: " + vidaActual1);
        vidaActual2 = vidaInicial - da�oRecibido2;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual2);
        vidaActual3 = vidaInicial - da�oRecibido3;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual3);
        vidaActual4 = vidaInicial - da�oRecibido4;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual4);
        vidaActual5 = vidaInicial - da�oRecibido5;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120;
    float daño1 = 0.03f,daño2=0.06f,daño3=0.09f,daño4=0.12f,daño5=0.15f;
    // Start is called before the first frame update
    void Start()
    {
        float dañoRecibido1 = vidaInicial * daño1;
        float dañoRecibido2 = vidaInicial * daño2;
        float dañoRecibido3 = vidaInicial * daño3;
        float dañoRecibido4 = vidaInicial * daño4;
        float dañoRecibido5 = vidaInicial * daño5;
        float vidaActual1 = vidaInicial - dañoRecibido1;
        float vidaActual2 = vidaInicial - dañoRecibido2;
        float vidaActual3 = vidaInicial - dañoRecibido3;
        float vidaActual4 = vidaInicial - dañoRecibido4;
        float vidaActual5 = vidaInicial - dañoRecibido5;
        Debug.Log("Has recibido un 3% daño, tu vida actual es: " + vidaActual1);
        vidaActual2 = vidaInicial - dañoRecibido2;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual2);
        vidaActual3 = vidaInicial - dañoRecibido3;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual3);
        vidaActual4 = vidaInicial - dañoRecibido4;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual4);
        vidaActual5 = vidaInicial - dañoRecibido5;
        Debug.Log("El veneno te ha vuelto a quitar vida, tu salud actual es: " + vidaActual5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

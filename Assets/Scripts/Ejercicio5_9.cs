using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    int danno, vida;

    // Start is called before the first frame update
    void Start()
    {
        LectorEnemigo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LectorEnemigo()
    {
        if (tipo == 1)
        {
            danno = 350;
            vida = 650;
            Debug.Log("A aparecido el enemigo 1, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else if(tipo == 2)
        {
            danno = 300;
            vida = 550;
            Debug.Log("A aparecido el enemigo 2, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else if (tipo == 3)
        {
            danno = 300;
            vida = 500;
            Debug.Log("A aparecido el enemigo 3, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else if (tipo == 4)
        {
            danno = 310;
            vida = 460;
            Debug.Log("A aparecido el enemigo 4, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else if (tipo == 5)
        {
            danno = 280;
            vida = 490;
            Debug.Log("A aparecido el enemigo 5, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else if( tipo == 6)
        {
            danno = 360;
            vida = 520;
            Debug.Log("A aparecido el enemigo 6, el daño que hace es: " + danno + ", y su vida es: " + vida);
        }
        else
        {
            Debug.Log("Introduzca un numero valido gentuzo");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Protagonista protagonista1= null;
    [SerializeField] Protagonista protagonista2 =null;
    bool yaEjecutado = true;
    void Start()
    {
        //PrepararPersonajes();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
            yaEjecutado = true;
        }
    }
    void PrepararPersonajes()
    {
        if(!protagonista1 || !protagonista2)
        {
            Debug.Log("Personaje no existente");
            return;
        }

        protagonista1.Nombre = "Ike";
        protagonista1.Vida = 450f;
        protagonista1.Exp = 5000f;
        float nivel1=protagonista1.CalcularNivel();
        Debug.Log("El Mercenario se llama: " + protagonista1.Nombre + ", su vida es: " + protagonista1.Vida + ", y su nivel es: " + nivel1);

        protagonista2.Nombre = "Mia";
        protagonista2.Vida = 375f;
        protagonista2.Exp = 2000f;
        float nivel2 = protagonista2.CalcularNivel();
        Debug.Log("La Espadachina se llama: " + protagonista2.Nombre + ", su vida es: " + protagonista2.Vida + ", y su nivel es: " + nivel2);


    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    //Variables Globales. Las que nombras en la clase.
    //[SerializeField] int vida = 5; con esta funcion podemos verlo sin que sea publico. Si serializamos no le ponemos valor. Ya que se muestra por el inspector.
    void Start()
    {
        //VariablesLocales. Las que nombras dentro de un metodo.
        int resultado = SumarDosNumeros(8,9);//Llamada del metodo
        Debug.Log(resultado);
    }

    
    void Update()
    {
        
    }

    //Implementar
    int SumarDosNumeros(int numero1, int numero2)// Conviertes el void a int ya que es lo que vas a retornar(string, float, void), y dentro creas el return.
    {
        int resultado=numero1 + numero2;
        return resultado;
        
    }

    //void RestarDosNumeros()
    //{

    //}

    //void Atacar()
    //{

    //}
}

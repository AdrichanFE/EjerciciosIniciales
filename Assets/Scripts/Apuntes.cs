using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    //Variables Globales. Las que nombras en la clase.
    //[SerializeField] int vida = 5; con esta funcion podemos verlo sin que sea publico. Si serializamos no le ponemos valor. Ya que se muestra por el inspector.

   //[SerializeField] bool carnetConducir;






    void Start()
    {
        //int vidas = 100;
        // int resultado1= SumarNumeros(1,2);
        //int resultado2= sumarNumeros(3,4);
        // int resultadoUnico= resultado1 + resultado2;
        //VariablesLocales. Las que nombras dentro de un metodo.
        //int resultado = SumarDosNumeros(8,9);//Llamada del metodo
        //Debug.Log(resultado);
        
        //if (carnetConducir == true)
        //{
        //    Debug.Log("Puedes Conducir");
        //}
        //else
        //{
        //    Debug.Log("A donde vas loco");
        //}

        //Siempre se comienza por los &&(AND), y se continua por el ||(OR), si usas parentesis puedes cambiar el orden.

        //if (nivel % 2 == 0) ; Con esto hacemos una division que te da el resto, y se puede usar para comprobar si algo es par.

        //while (vidas > 0)
        //{
        //    Debug.Log("Sigo vivo");
        //}

        //BUCLE FOR
        //for (int i = 0; i < 10; i++) //El numero que se pone despues de la segunda i es el numero de vueltas que va a realizar el bucle.

        for (int niveles = 0;niveles < 5; niveles++)
        {
            for(int rondas = 0; rondas < 10; rondas++)
            {
                for (int enemigos = 0; enemigos < 10; enemigos++)
                {
                    Debug.Log("Sale el enemigo " + enemigos + ", de la ronda " + rondas + ", del nivel " + niveles);
                }
            }
        }

    }

    
    void Update()
    {
        
    }

    //Implementar
    //int SumarDosNumeros(int numero1, int numero2)// Conviertes el void a int ya que es lo que vas a retornar(string, float, void), y dentro creas el return.
    //{
    //    int resultado=numero1 + numero2;
    //    return resultado;
        
    //}

    //void RestarDosNumeros()
    //{

    //}

    //void Atacar()
    //{

    //}
}

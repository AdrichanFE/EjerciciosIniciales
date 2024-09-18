using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float areaCirculo, areaTriangulo, areaCuadrado;
    float radio = 12, bse = 24, altura = 36, lado = 16;

    // Start is called before the first frame update
    void Start()
    {
        AreaDelCirculo();
        Debug.Log("El area del circulo es igual a: " + areaCirculo);
        AreaDelTriangulo();
        Debug.Log("El area del triangulo es igual a: " + areaTriangulo);
        AreaDelCuadrado();
        Debug.Log("El area del cuadrado es igual a:" + areaCuadrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AreaDelCirculo()
    {
        areaCirculo = (radio * radio) * 3.14f;
        
    }
    void AreaDelTriangulo()
    {
        areaTriangulo = (bse * altura) / 2;
    }
    void AreaDelCuadrado()
    {
        areaCuadrado = lado * lado;
    }
}

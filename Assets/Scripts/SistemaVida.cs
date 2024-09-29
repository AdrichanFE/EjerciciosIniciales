using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RecibirCura(50);
        RecibirDanno(100);
    }
    float RecibirCura(float cantidad)
    {
        if (vidaActual>= vidaInicial)
        {
            vidaInicial = vidaInicial;
        }
        if (vidaActual < vidaInicial)
        {
            vidaActual = cantidad + vidaActual;
        }
        return vidaActual;
    }
    float RecibirDanno(float danno)
    {
        if(vidaActual<= 0)
        {
            vidaInicial = 0;
        }
        if(vidaActual < vidaInicial)
        {
            vidaActual=vidaInicial -= danno;
        }
        return vidaActual;
    }
}

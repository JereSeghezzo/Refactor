using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03Refact : MonoBehaviour
{
    int resistencia;
    int vida;
    int nivelResistencia;
    int reduccionDa�o;

    void RacibirDa�o(int da�o)
    {
        int da�oProxy = da�o;
        if (resistencia > nivelResistencia)
        {
            da�oProxy -= reduccionDa�o;
        }

        vida -= da�oProxy;

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03Refact : MonoBehaviour
{
    int resistencia;
    int vida;
    int nivelResistencia;
    int reduccionDaño;

    void RacibirDaño(int daño)
    {
        int dañoProxy = daño;
        if (resistencia > nivelResistencia)
        {
            dañoProxy -= reduccionDaño;
        }

        vida -= dañoProxy;

    }
}
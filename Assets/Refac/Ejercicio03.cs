using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    int resistencia;
    int vida;

    void RacibirDaño(int daño)
    {

        if (resistencia > 5)
        {
            daño -= 2;

        }

        vida -= daño;

    }
}

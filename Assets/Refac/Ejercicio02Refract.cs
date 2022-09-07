using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02Refract : MonoBehaviour
{
    int fuerza;
    int agilidad;


    private void Start()
    {
       fuerza = 100;
       agilidad = 50;
    }

    private void AtaqueEspecial()
    {
        bool fuerzaFinal = (fuerza * 2) / 5 > -1;
        bool agilidadFinal = agilidad / 2 > 20;
        if (fuerzaFinal && agilidadFinal)

        {
            Debug.Log("Ataque especial");
        }
    }
}
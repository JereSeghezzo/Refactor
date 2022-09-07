using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    int fuerza = 100;
    int agilidad = 50;


    private void Start()
    {

    }

    private void Update()
    {

    }

    private void AtaqueEspecial()
    {
        if ((fuerza * 2) / 5 > -1 && (agilidad / 2 > 20))

        {
            Debug.Log("Ataque especial");
        }
    }
}
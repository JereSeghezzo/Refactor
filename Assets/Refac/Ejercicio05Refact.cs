using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05Refact : MonoBehaviour
{
    [Range(1, 20)]
    int probabilidad_Critico;

    int minGolpe_Critico;

    public void DañoCritico()
    {
        int dado = Random.Range(0, probabilidad_Critico);

        if (dado > minGolpe_Critico)
        {
            Debug.Log("Golpe Critico");
        }
        else
        {
            Debug.Log("Golpe Normal");
        }

    }
}

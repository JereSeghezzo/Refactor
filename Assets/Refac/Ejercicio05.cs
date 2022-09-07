using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    [Range(1, 20)]
    int Probabilidad_Critico;

    public void DañoCritico()
    {
        int Dado = Random.Range(0, Probabilidad_Critico);

        if (Dado > 15)
        {
            Debug.Log("Golpe Critico");
        }
        else
        {
            Debug.Log("Golpe Normal");
        }

    }
}

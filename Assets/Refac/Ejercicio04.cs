using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    string BuscarEnemigos(string[] enemigos)
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (enemigos[i].Equals("Araña"))
            {
                return "Araña";
            }
            if (enemigos[i].Equals("Lobo"))
            {
                return "Lobo";
            }
            if (enemigos[i].Equals("Orco"))
            {
                return "Orco";
            }
        }
        return String.Empty;
    }
}
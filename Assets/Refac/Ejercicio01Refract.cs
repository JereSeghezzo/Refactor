using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01Refract : MonoBehaviour
{
    public float fuerza;
    private Rigidbody2D _rb2d;
    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        Vector2 velocidad = new Vector2(x, y);

        _rb2d.AddForce(velocidad * fuerza * Time.deltaTime);
    }

}

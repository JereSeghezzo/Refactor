using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public float Fuerza = 100f;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        Vector2 Velocidad = new Vector2(x, y);

        rb2d.AddForce(Velocidad * Fuerza * Time.deltaTime);

    }
}

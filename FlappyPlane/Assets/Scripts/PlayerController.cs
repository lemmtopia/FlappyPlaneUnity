using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidade
    [SerializeField] private float velPulo;

    // Meu rb
    private Rigidbody2D rb;

    void Start()
    {
        // Pegando meu rigidbody 2d via código
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Pular se eu apertar o espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velPulo;
        }
    }
}

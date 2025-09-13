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
        Subir();
        LimitarQueda();
    }

    public void Subir()
    {
        // Pular se eu apertar o espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velPulo;
        }
    }

    public void LimitarQueda()
    {
        // Limitando minha velocidade de queda caso ela for maior que velPulo
        if (rb.velocity.y < -velPulo)
        {
            rb.velocity = Vector2.down * velPulo;
        }
    }
}

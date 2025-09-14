using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Objeto do puf
    [SerializeField] private GameObject puf;

    // Velocidade
    [SerializeField] private float velPulo;
    [SerializeField] private float yLimite = 5.5f;

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

        ChecarBordas();
    }

    public void Subir()
    {
        // Pular se eu apertar o espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velPulo;

            // Criando meu novo puf
            GameObject novoPuf = Instantiate(puf, transform.position, Quaternion.identity);
            Destroy(novoPuf, 1f); // Destruindo o meu puf depois de 1 segundo
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

    private void ChecarBordas()
    {
        if (transform.position.y < -yLimite || transform.position.y > yLimite)
        {
            PerdeJogo();
        }
    }


    // Colisão com os triggers
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PerdeJogo();
    }

    private void PerdeJogo()
    {
        // Reiniciando a minha sala
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade;

    [SerializeField] private GameController game;

    void Start()
    {
        // Encontrando o game controller da cena atual
        game = FindObjectOfType<GameController>();
    }

    void Update()
    {
        transform.position += Vector3.left * velocidade * game.PegaLevel() * Time.deltaTime;

        // Destruindo caso eu sair pela esquerda
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}

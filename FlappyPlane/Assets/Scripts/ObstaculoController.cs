using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    private float velocidade;
    private GameController game;

    void Start()
    {
        // Encontrando o game controller da cena atual
        game = FindObjectOfType<GameController>();

        velocidade = 4f + game.PegaLevel();
    }

    void Update()
    {
        // Me movendo
        velocidade = 4f + game.PegaLevel();
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        // Destruindo caso eu sair pela esquerda
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}

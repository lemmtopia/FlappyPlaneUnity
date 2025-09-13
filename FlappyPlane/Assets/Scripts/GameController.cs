using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Obstaculo
    [SerializeField] private GameObject obstaculo;
    
    // Valores do Y do obstaculo

    // Tempo para criar o obstaculo
    [SerializeField] private float tempoObstaculo;

    // Tempo atual
    private float tempo;

    void Start()
    {
        // Iniciando o tempo como o tempo do obstaculo
        tempo = tempoObstaculo;
    }

    void Update()
    {
        // Diminuindo meu tempo
        tempo -= Time.deltaTime;

        // Checando se o tempo passou
        if (tempo <= 0)
        {
            // Calculando a posição do obstaculo
            Vector3 posicaoObstaculo = new Vector3(12, 0, 0);

            // Criando o obstaculo
            Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);
            
            tempo = tempoObstaculo; // Reiniciando o timer
        }
    }
}

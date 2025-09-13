using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Obstaculo
    [SerializeField] private GameObject obstaculo;

    // Valores do Y do obstaculo
    [SerializeField] private float obstaculoMinY;
    [SerializeField] private float obstaculoMaxY;

    // Tempo para criar o obstaculo
    [SerializeField] private float minTempoObstaculo;
    [SerializeField] private float maxTempoObstaculo;

    // Tempo atual
    private float tempo;

    void Start()
    {

    }

    void Update()
    {
        // Diminuindo meu tempo
        tempo -= Time.deltaTime;

        // Checando se o tempo passou
        if (tempo <= 0)
        {
            // Calculando a posição do obstaculo
            Vector3 posicaoObstaculo = new Vector3(12, Random.Range(obstaculoMinY, obstaculoMaxY), 0);

            // Criando o obstaculo
            Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);
            
            tempo = Random.Range(minTempoObstaculo, maxTempoObstaculo); // Reiniciando o timer
        }
    }
}

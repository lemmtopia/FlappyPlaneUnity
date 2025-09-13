using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Texto de pontos
    [SerializeField] private Text pontosTexto;

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

    // Pontos
    private float pontos;

    void Start()
    {

    }

    void Update()
    {
        GanharPontos();
        CriarObstaculos();
    }

    private void GanharPontos()
    {
        // Ganhar pontos
        pontos += Time.deltaTime;

        // Atualizar texto
        pontosTexto.text = "Pontos: " + Mathf.Round(pontos).ToString();
    }

    private void CriarObstaculos()
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

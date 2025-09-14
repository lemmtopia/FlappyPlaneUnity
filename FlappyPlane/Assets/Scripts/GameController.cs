using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Texto de pontos
    [SerializeField] private Text pontosTexto;

    // Texto de level
    [SerializeField] private Text levelTexto;

    // Pontos pro pr�ximo level
    [SerializeField] private float pontosLevel;
    [SerializeField] private float multPontosLevel;

    // Obstaculo
    [SerializeField] private GameObject obstaculo;

    // Valores do Y do obstaculo
    [SerializeField] private float obstaculoMinY;
    [SerializeField] private float obstaculoMaxY;

    // Tempo para criar o obstaculo
    [SerializeField] private float minTempoObstaculo;
    [SerializeField] private float maxTempoObstaculo;

    // Som
    private AudioSource somLevelUp;

    // Tempo atual
    private float tempo;

    // Pontos
    private float pontos = 0;

    // N�vel
    private int level = 1;

    void Start()
    {
        // Pegando meu som do level up
        somLevelUp = GetComponent<AudioSource>();
    }

    void Update()
    {
        GanharPontos();
        GanharLevel();
        CriarObstaculos();
    }

    private void GanharPontos()
    {
        // Ganhar pontos
        pontos += Time.deltaTime * level;

        // Atualizar texto
        pontosTexto.text = "Pontos: " + Mathf.Round(pontos).ToString();
    }

    private void GanharLevel()
    {
        if (pontos >= pontosLevel)
        {
            // Subindo de n�vel
            level++;
            pontosLevel *= multPontosLevel;

            // Tocando o meu som
            somLevelUp.Play();
        }

        // Atualizando o texto de n�vel
        levelTexto.text = level.ToString();
    }

    private void CriarObstaculos()
    {
        // Diminuindo meu tempo
        tempo -= Time.deltaTime;

        // Checando se o tempo passou
        if (tempo <= 0)
        {
            // Calculando a posi��o do obstaculo
            Vector3 posicaoObstaculo = new Vector3(12, Random.Range(obstaculoMinY, obstaculoMaxY), 0);

            // Criando o obstaculo
            Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);

            tempo = Random.Range(minTempoObstaculo / level, maxTempoObstaculo); // Reiniciando o timer
        }
    }

    public int PegaLevel()
    {
        return level;
    }
}

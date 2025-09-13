using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float tempoMontanha;
    private float tempo;

    void Start()
    {
        // Iniciando o tempo como o tempo da montanha
        tempo = tempoMontanha;
    }

    void Update()
    {
        // Diminuindo meu tempo
        tempo -= Time.deltaTime;

        // Checando se o tempo passou
        if (tempo <= 0)
        {
            Debug.Log("oi");
            tempo = tempoMontanha; // Reiniciando o timer
        }
    }
}

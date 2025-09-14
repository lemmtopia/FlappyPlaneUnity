using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // Mudar de tela se eu apertar o espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Carregando a tela do jogo.
            SceneManager.LoadScene(1);
        }
    }
}

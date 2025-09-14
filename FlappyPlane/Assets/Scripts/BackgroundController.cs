using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.1f;

    //private GameController game;
    private Renderer renderer;

    // x offset
    private float xOffset = 0;

    void Start()
    {
        // Pegando o meu renderer
        renderer = GetComponent<Renderer>();

        //game = FindObjectOfType<GameController>();
    }

    void Update()
    {
        // Movendo o offset x do meu renderer
        xOffset += velocidade * Time.deltaTime;
        renderer.material.mainTextureOffset = new Vector2(xOffset, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFundo : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 3;

        rbd = GetComponent<Rigidbody2D>();

        rbd.velocity = new Vector2(0, -velocidade);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) //-10 pois o tamnnho da cameraSize é 5, entao eu multiplico por 2 pra pegar o tamanho da tela inteira, e jogo pra negativo pra pegar o fim de baixo da tela.
            transform.position = new Vector2(0, 10);
    }
}

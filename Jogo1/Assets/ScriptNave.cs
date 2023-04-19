using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptNave : MonoBehaviour
{
    public GameObject tiro;
    private float altura;
    private float largura;
    public float vel;
    private AudioSource som; //criando a variavel que vai ser a referencia do audio source
    private Rigidbody2D rbd;//criando atributo rigid, para a classe, adicionando assim fisica ao objeto Nave.
    // Start is called before the first frame update
    void Start()
    {
        som = GetComponent<AudioSource>();// iniciando a variavel de som
        rbd = this.GetComponent<Rigidbody2D>(); //corpo fisico do objeto
        vel = 15;
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

    }

    // Update is called once per frame
    void Update()
    {
        float x;
        float y;
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rbd.velocity = new Vector2(x,y) * vel;

        TranslateNave();
        TiroNave();
    }

    public void TranslateNave()
    {
        if (this.transform.position.x > largura)
            transform.position = new Vector2(-largura, transform.position.y);
        else if (this.transform.position.x < -largura)
            transform.position = new Vector2(largura, transform.position.y);

        if (transform.position.y > 0)
            transform.position = new Vector2(transform.position.x, 0);
        else if (transform.position.y < -altura)
            transform.position = new Vector2(transform.position.x, -altura);

    }

    public void TiroNave()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ScritpCJOGO.pause)// verifica se o espaço foi apertado e se o jogo nao esta pausado, ae ele atira.
        {

            Vector2 tiroEsquerdo = new Vector2(transform.position.x + -1.1f, transform.position.y + 0.9f);
            Vector2 tiroDireito = new Vector2(transform.position.x + 1.1f, transform.position.y + 0.9f);
            som.Play();
            Instantiate(tiro, tiroEsquerdo, Quaternion.identity);
            Instantiate(tiro, tiroDireito, Quaternion.identity);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRespawn : MonoBehaviour
{
    public GameObject npc;
    private float largura;

    // Start is called before the first frame update
    void Start()
    {
        largura = Camera.main.orthographicSize * Camera.main.aspect;// calcula a largura no meio da tela para a direita.
        InvokeRepeating("respawn",0,1); // vai invocar um metodo repetidas vezes
    }

    private void respawn ()
    {
        float posX = Random.Range(-largura, largura);//gera um numero randomico na largura total da tela.
        Vector2 pos = new Vector2(posX, 6);// adiciona a posição que a nave vai aparecer
        Instantiate(npc, pos, Quaternion.identity);// cria uma instancia do npc(um objeto)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

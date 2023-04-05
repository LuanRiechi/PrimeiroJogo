using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScritpCJOGO : MonoBehaviour
{
    public static bool pause = false;

    private void Start()
    {
        pause = false; //toda vez que carregar o jogo vai ter a certeza que nao esta pausado, fazendo assim a nave poder atirar denovo.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause) {
                Time.timeScale = 1;
                SceneManager.UnloadScene(0);//descarrega a cena 0
            }
            else
            {
                Time.timeScale = 0; //modifica a velocidade do jogo.
                SceneManager.LoadScene(0, LoadSceneMode.Additive);//carrega a cena nova em adição a cena que ja existe, fica uma por cima da outra, com a de baixo pausada por caisa da velocidade = 0

            }
            pause = !pause;

        }
        
    }
}

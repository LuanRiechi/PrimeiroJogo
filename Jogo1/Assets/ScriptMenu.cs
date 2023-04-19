using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// importando o gereciador de cena

public class ScriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Iniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Sair()
    {
        Application.Quit();//so funciona quando der build no jogo.
    }

    public void Voltar()
    {
        SceneManager.LoadSceneAsync(0);
    }


}

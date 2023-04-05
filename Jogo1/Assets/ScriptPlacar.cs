using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptPlacar : MonoBehaviour
{
    private static int placar = 0;
    public static GameObject textPlacar;
    // Start is called before the first frame update
    void Start()
    {
        textPlacar = GameObject.Find("TextPlacar");

    }

    public static void incrementarPlacar(int inc)
    {
        placar += inc;
        textPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;//pega o campo de variavel que define o texto desse componente e adicona novo texto a ela.

    }
    // nao precisa do metodo update

}

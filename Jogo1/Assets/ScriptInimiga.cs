using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInimiga : MonoBehaviour
{
    public Rigidbody2D rbd;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 5;
        rbd.velocity = new Vector2(0, -vel);
    }

    private void OnTriggerEnter2D(Collider2D collision)//collision é o objeto que esta colidindo com essa instancia.
    {
        if (collision.tag.Equals("tiro"))//verifica se a colisão foi com o tiro, pela tag q defini no asset de tiro.
            ScriptPlacar.incrementarPlacar(5);


        Destroy(collision.gameObject);
        Destroy(this.gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize)
            Destroy(this.gameObject);

        
    }
}

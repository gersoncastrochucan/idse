using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class premio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
       // player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            agregarUnAnimalAlInventario();
            Destroy(this.gameObject);

            //  Destroy(col.gameObject);          
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.tag.Equals("Player")))
        {
            // agregar o hacer el metodo para agregar al inventario
            agregarUnAnimalAlInventario();
            // luego destruirlo
           // Destroy(this.gameObject);
        }
    }

    public void agregarUnAnimalAlInventario() {
        // Aqui codigo para agregat un aleatorio al inventario
        print("Agregar inventario ");
    }
}

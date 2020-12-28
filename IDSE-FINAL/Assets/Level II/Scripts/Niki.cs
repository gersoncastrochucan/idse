using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Niki : MonoBehaviour
{
    public float upForce = 100;                 //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?

    private Animator anim;                  //Reference to the Animator component.
    Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.
    public static int contador=0;
    public static int contadorReciclaje = 0;
    public Text puntos;
    int metaRescatar;
    int metaLimpiar;


    void Start()
    {
        //Get reference to the Animator component attached to this GameObject.
        anim = GetComponent<Animator>();
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();
        contador = 0;
        contadorReciclaje = 0;
        metaRescatar = 2;
        metaLimpiar = 2;
        puntos.text = "Rescates: " + contador + "\nLimpieza: " + contadorReciclaje;
    }

    void Update()
    {

        //Don't allow control if the character has died.
       if (isDead == false)
      {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonUp(0))  // if (Input.GetMouseButtonDown(0)) 
            {
                //...tell the animator about it and then...
                anim.SetTrigger("Niki_nadando");

                //...zero out the birds current y velocity before...
                rb2d.velocity = Vector2.zero;
                //	new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(0, upForce));
                rb2d.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -71.125f));
            }

            if (Input.GetMouseButtonUp(1))  // if (Input.GetMouseButtonDown(0)) 
            {
              
                rb2d.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -71.125f));
                rb2d.velocity = Vector2.zero;
                //rb2d.AddForce(new Vector2(0, upForce));
                // this.transform.RotateAround(transform.position, Vector2.up, 2 * Time.deltaTime);//rotation = rotateAround(0, 0, -71.125);
            }
        }
    }



    void OnCollisionEnter2D(Collision2D other)
    {

        if ((other.gameObject.tag.Equals("Obstaculo")))
        {
            rb2d.velocity = Vector2.zero;
            isDead = true;   // comentado porq no queremos que muera si se toca con cualquier cosa       
            anim.SetTrigger("Niki_muerto");
            GameControlGlow.instance.NikiDied();
        }
        else if(!other.gameObject.tag.Equals("Scenery"))
        {
              
            if (!other.gameObject.tag.Equals("Basura"))
            {
             //   other.gameObject.SetActive(false);
                Destroy(other.gameObject);
                contador = contador + 1; 
              
            }
            else // else aqui si son objetos reciclables
            {
                //other.gameObject.SetActive(false);
              Destroy(other.gameObject);
                contadorReciclaje = contadorReciclaje + 1;     
            }
            if ((contador + contadorReciclaje) >= metaRescatar )//(contador >= metaRescatar && contadorReciclaje>= metaLimpiar)
            {
                // niki gana y sale de la escena, talvez mostrando lo que rescató
                GameControlGlow.instance.NikiWin();
            }
            puntos.text = "Rescates: " + contador +"\nLimpieza: " + contadorReciclaje;
        }
    }
    
   
}

   

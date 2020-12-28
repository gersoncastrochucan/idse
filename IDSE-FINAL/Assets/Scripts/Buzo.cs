using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzo : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2D;
    public float upForce = 200f;
    private Animator anim;
    //public GameController gameController;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                upForce = 200f;
                rb2D.velocity = Vector2.zero;
                rb2D.AddForce(new Vector2(0, upForce));
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                anim.SetTrigger("Flap");

            }

         


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Residuo")
        {
            Debug.Log("Recogiendo basura");
        }
        else
        {
            isDead = true;
            anim.SetTrigger("Die");
            GameController.instance.BuzoDie();
            rb2D.velocity = Vector2.zero;
        }
        
    }
}

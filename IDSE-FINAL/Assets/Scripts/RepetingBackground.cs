using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update

    void Start()
    {
        groundHorizontalLength = groundCollider.size.x;
        //groundHorizontalLength = 20.14f;
    }

    private void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontalLength * 3);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }
}

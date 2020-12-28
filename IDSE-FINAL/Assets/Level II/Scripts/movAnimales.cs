using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movAnimales : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * velocidad * Time.deltaTime;
    }
}

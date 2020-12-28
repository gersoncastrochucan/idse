using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ZoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool bloqueado;
    public GameObject Arboles;
    public int pos = 0;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Arboles.gameObject.SetActive(!bloqueado);
    }
}

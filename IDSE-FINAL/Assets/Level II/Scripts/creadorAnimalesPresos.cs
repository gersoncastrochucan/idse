using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creadorAnimalesPresos : MonoBehaviour
{
    Vector3 lastLocation = new Vector3(0,0,0);
    public List <GameObject> animales= new List<GameObject>();
    public float tiempoCreacionMax = 5f, tiempoCreacionMin = 0f, RangoCreacion = 6f;
    int max =5;
    // Start is called before the first frame update
    void Start()
    {
        float rango = Random.Range(tiempoCreacionMin, tiempoCreacionMax);
        InvokeRepeating("Creando", 0.0f, rango);
    }

    // Update is called once per frame
    void Update()
    {        

    }
    // Rotación predeterminada
    public void Creando() {
      //  lastLocation = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        int num = Random.Range(0, animales.Count);
      float ale = lastLocation.x + Random.Range(0, max);
        Vector3 SpawnPosition = new Vector3(0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        GameObject Animal = Instantiate(animales[num], SpawnPosition, Quaternion.identity);

        //lastLocation = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creadorPremios: MonoBehaviour
{
    Vector3 lastLocation = new Vector3(0,0,0);
    public List <GameObject> premios= new List<GameObject>();
    public float tiempoCreacionMax = 10f, tiempoCreacionMin = 4f, RangoCreacion = 6f;
    int max =5;
    // Start is called before the first frame update
    void Start()
    {
        float rango = Random.Range(tiempoCreacionMin, tiempoCreacionMax);
        InvokeRepeating("Creando", 0.0f, rango); // 0.0
    }

    // Update is called once per frame
    void Update()
    {        

    }
    // Rotación predeterminada
    public void Creando() {
      //  lastLocation = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        int num = Random.Range(0, premios.Count);
      float ale = lastLocation.x + Random.Range(0, max);
        Vector3 SpawnPosition = new Vector3(0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        GameObject Premio = Instantiate(premios[num], SpawnPosition, Quaternion.identity);

        //lastLocation = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presosPool : MonoBehaviour
{
    public GameObject[] animalPresoPrefab;
    public int random = 0;
    public int presosPoolSize = 15;                                  //How many presos to keep on standby.
    public float spawnRate = 3f;                                    //How quickly presos spawn.
    public float columnMin = -1f;                                   //Minimum y value of the column position.
    public float columnMax = 3.5f;                                  //Maximum y value of the column position.

    private GameObject[] presos;                                   //Collection of pooled presos.
    private int currentColumn = 0;                                  //Index of the current column in the collection.

    private Vector2 objectPoolPosition = new Vector2(-15, -25);     //A holding position for our unused presos offscreen.
    private float spawnXPosition = 10f;

    private float timeSinceLastSpawned;


    void Start()
    {
        for (int i = 0; i < animalPresoPrefab.Length; i++)
        {
            animalPresoPrefab[i].SetActive(true);
        }
        timeSinceLastSpawned = 0f;

        //Initialize the presos collection.
        presos = new GameObject[presosPoolSize];
        //Loop through the collection... 
        for (int i = 0; i < presosPoolSize; i++)
        {
            random = Random.Range(0, animalPresoPrefab.Length - 1);
            //...and create the individual presos.
            presos[i] = (GameObject)Instantiate(animalPresoPrefab[random], objectPoolPosition, Quaternion.identity);
        }
    }


    //This spawns presos as long as the game is not over.
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControlGlow.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            //Set a random y position for the column
            float spawnYPosition = Random.Range(columnMin, columnMax);

            //...then set the current column to that position.
            presos[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            //Increase the value of currentColumn. If the new size is too big, set it back to zero
            currentColumn++;

            if (currentColumn >= presosPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}

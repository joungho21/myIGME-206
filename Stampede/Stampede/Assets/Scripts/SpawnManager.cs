using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabAnimals;
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, prefabAnimals.Length);
        Instantiate(prefabAnimals[animalIndex], 
            new Vector3(Random.Range(-playerController.xRange, playerController.xRange), 0, 25), 
            prefabAnimals[animalIndex].transform.rotation );
    }
}

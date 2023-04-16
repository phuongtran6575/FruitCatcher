using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    [SerializeField]private GameObject[] fruitPrefabs;
   
    private int minFruits = 1; //
    private int maxFruits = 6; 

    // Start is called before the first frame update
    private void Start()
    {
        
        InvokeRepeating("SpawnFruit", 1f, 2f);
    }

    // Update is called once per frame
    private void SpawnFruit()
    {
        int numBalls = Random.Range(minFruits, maxFruits + 1); 

        for (int i = 0; i < numBalls; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-2f, 4f), 0f);
            GameObject ball = Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Length)], spawnPosition, Quaternion.identity); 
        }


    }
}

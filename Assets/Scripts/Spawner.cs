using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public EnemyFactory factory;
    public float timeBetweenSpawns;
    public List<IProduct> spawnedProducts;
    private float spawnTimer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnedProducts=new List<IProduct>();
        spawnTimer = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer <= 0)
        {
            //spawning
            IProduct p = factory.produce();
            spawnedProducts.Add(p);
            
            spawnTimer = timeBetweenSpawns;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}

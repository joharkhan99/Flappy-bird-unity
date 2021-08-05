using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxYPos;
    public float spawnTime;
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        startSpawningPipes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        //Instantiate(gameobject,x,y,z).no rotation
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYPos, maxYPos), 0),Quaternion.identity);   //Quaternion.identity means we dont want any rotation we just want simple rotation
    }

    public void startSpawningPipes()
    {
        InvokeRepeating("SpawnPipe", 0.2f, spawnTime);
    }

    public void stopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }
}

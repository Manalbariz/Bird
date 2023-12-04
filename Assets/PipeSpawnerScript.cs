using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRat = 5;
    private float timer = 0;
    public float heightOfset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRat)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowerPoint = transform.position.y - heightOfset;
        float highestPoint = transform.position.y + heightOfset;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowerPoint,highestPoint),0), transform.rotation);

    }
}

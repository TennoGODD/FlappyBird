using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float TimeToSpawn,minY,maxY;
    private float timer;


    private void Update() {
        if(timer <= 0)
        {
            timer = TimeToSpawn;
            GameObject pipe = Instantiate(pipePrefab,transform.position,quaternion.identity);
            float rand = UnityEngine.Random.Range(minY,maxY);
            pipe.transform.position = new Vector3(pipe.transform.position.x,rand,0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public BirdMove Birdscript;
    public GameObject Pipes ;

    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!Birdscript.isdead)
        {
           Instantiate(Pipes, new Vector3(3, Random.Range(-height,height),0), Quaternion.identity);
             yield return new WaitForSeconds(time);
        }
        
    }
}

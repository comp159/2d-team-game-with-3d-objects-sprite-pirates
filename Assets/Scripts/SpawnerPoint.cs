using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    public Transform[] spawnLocation;
    public GameObject[] Spawn_Prefab;
    public GameObject[] Spawn_Clone;
    void Start()
    {
        Spawn_This();
    }

    void Spawn_This()
    { 
        Spawn_Clone[0] = Instantiate(Spawn_Prefab[0], spawnLocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }


    void Update()
    {
        
    }
}

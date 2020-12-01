﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawmer;

    // Start is called before the first frame update
    void Start()
    {
        roadSpawmer = GetComponent<RoadSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        roadSpawmer.MoveRoad();
    }

}

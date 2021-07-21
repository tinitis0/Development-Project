﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrap : MonoBehaviour
{

    private float timeBetweenShots;
    public float startTimeBetweenShots;

    public GameObject projectile;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        timeBetweenShots = startTimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenShots <= 0)
        {
            Instantiate(projectile, firePoint.position, Quaternion.identity);
            timeBetweenShots = startTimeBetweenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }

    
}

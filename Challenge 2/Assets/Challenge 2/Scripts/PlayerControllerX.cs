﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            cooldown = 2;
        }

        cooldown = cooldown - Time.deltaTime;
    }
}

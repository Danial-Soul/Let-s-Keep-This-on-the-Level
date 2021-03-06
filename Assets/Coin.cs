﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float spinSpeed = 100f;

    void Update()
    {
        this.transform.Rotate(0f, 0f, Time.deltaTime * this.spinSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.score++;
        Destroy(this.gameObject);
    }
}
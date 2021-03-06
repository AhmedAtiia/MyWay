﻿using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    public float speedDiff;
    public float destroySeconds;

    // Use this for initialization
    void Start()
    {

        // destroy object after x seconds
        Destroy(this.gameObject, destroySeconds);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // add forward force to the Explosion
        GetComponent<Rigidbody>().velocity = transform.forward * -(speedDiff + GameController.gameSpeed);
    }
}

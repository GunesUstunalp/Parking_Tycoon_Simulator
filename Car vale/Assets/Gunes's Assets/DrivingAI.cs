using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DrivingAI : MonoBehaviour
{
    public float targetX, targetZ;
    public float speed;
    Vector3 currentPos;

    void Start()
    {
        
    }

    void Update()
    {
        currentPos = transform.position;

        double distance = Math.Sqrt(Math.Pow((targetX - currentPos.x), 2)
                + Math.Pow((targetZ - currentPos.z), 2));

        double slopeZ = (targetZ - currentPos.z) / distance;
        double slopeX = (targetX - currentPos.x) / distance;

        if (distance > 1)
            transform.position += new Vector3((float)(Time.deltaTime * speed * slopeX), transform.position.y, (float)(Time.deltaTime * speed * slopeZ));

    }
}

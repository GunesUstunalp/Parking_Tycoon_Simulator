using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Walking : MonoBehaviour
{   
    Animator animator;
    public float targetX, targetZ;
    public float speed;
    Vector3 currentPos;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        speed = 1;
    }

    void Update()
    {
        currentPos = transform.position;

        double distance = Math.Sqrt(Math.Pow((targetX - currentPos.x), 2)
                + Math.Pow((targetZ - currentPos.z), 2));
        Debug.Log(distance);

        if (distance > 0.1)
        {
            animator.SetBool("WalkingTrigger", true);

            double slopeZ = (targetZ - currentPos.z) / distance;
            double slopeX = (targetX - currentPos.x) / distance;

            transform.position += new Vector3((float)(Time.deltaTime * speed * slopeX), transform.position.y , (float)(Time.deltaTime* speed * slopeZ));

        }
        else
            animator.SetBool("WalkingTrigger", false);

    }
}

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
    }

    void Update()
    {
        currentPos = transform.position;

        double distance = Math.Sqrt(Math.Pow((targetX - currentPos.x), 2)
                + Math.Pow((targetZ - currentPos.z), 2));

        double slopeZ = (targetZ - currentPos.z) / distance;
        double slopeX = (targetX - currentPos.x) / distance;

        double angle = Math.Asin(slopeZ);
        angle = angle * 180 / Math.PI;

        //Vector3 to = new Vector3(0, (float)angle, 0);

        //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);

        if (distance > 0.01)
        {
            animator.SetBool("WalkingTrigger", true);
            transform.position += new Vector3((float)(Time.deltaTime * speed * slopeX), transform.position.y , (float)(Time.deltaTime* speed * slopeZ));
        }
        else
            animator.SetBool("WalkingTrigger", false);

    }
}

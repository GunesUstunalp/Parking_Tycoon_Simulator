using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnterCars : MonoBehaviour
{
    GameObject car;

    public bool floorB = false;
    public bool rearB = false;
    public bool frontB = false;
    public bool leftB = false;
    public bool rightB = false;

    private void FixedUpdate()
    {
        if (floorB)
        {
            if(!rearB && !frontB && !leftB && !rightB)
            {
                Debug.Log("Park edildi");
                //GameObject parkSpace = GameObject.Find("GameManager");
                //GameManager gM = (GameManager)parkSpace.GetComponent(typeof(GameManager));
                //gM.dailyParkCount++;
            }
        }
        else
        {
            return;
        }
    }
}
    //if(topHeaderBoxCollider.bounds.Intersects(currentHeader.boxCollider.bounds))



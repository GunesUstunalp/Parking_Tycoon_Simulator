using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingPlaceHandler : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("Entered ; " + entered);
    }
    bool entered = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "car")
        {
            entered = true;
        }
        else
        {
            entered = false;
        }
    }
}

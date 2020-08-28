using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    //GameObject audioM = GameObject.Find("AudioHandler");
    //AudioManager aManager = (AudioManager)audioM.GetComponent(typeof(AudioManager));
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "car"){
            GameObject parkSpace = GameObject.Find("ParkingArea");
            CollisionEnterCars cec = (CollisionEnterCars)parkSpace.GetComponent(typeof(CollisionEnterCars));
            if(gameObject.name == "Floor")
            {
                cec.floorB = true;
            }
            if (gameObject.name == "Front")
            {
                cec.frontB = true;
            }
            if (gameObject.name == "LeftSide")
            {
                cec.leftB = true;
            }
            if (gameObject.name == "rearSide")
            {
                cec.rearB = true;
            }
            if (gameObject.name == "RightSide")
            {
                cec.rightB = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            GameObject parkSpace = GameObject.Find("ParkingArea");
            CollisionEnterCars cec = (CollisionEnterCars)parkSpace.GetComponent(typeof(CollisionEnterCars));
            if (gameObject.name == "Floor")
            {
                cec.floorB = false;
            }
            if (gameObject.name == "Front")
            {
                cec.frontB = false;
            }
            if (gameObject.name == "LeftSide")
            {
                cec.leftB = false;
            }
            if (gameObject.name == "rearSide")
            {
                cec.rearB = false;
            }
            if (gameObject.name == "RightSide")
            {
                cec.rightB = false;
            }
        }
    }
}

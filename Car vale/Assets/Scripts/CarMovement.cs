using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // public bool active = true;
    public AudioSource idleSound;
    public bool turn = true;
    public bool soundActive = false;
    
    public GameObject frontLights;
    public GameObject backLights;
    public GameObject smoke;
    public GameObject gasSmoke;

    public Rigidbody rb;
    public Transform car;
    public float speed = 17;
    public Transform carRight;
    public Transform carLeft;
    //public GameObject smoke;

    Vector3 rotationRight = new Vector3(0, 80, 0);
    Vector3 rotationLeft = new Vector3(0, -80, 0);
    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    //int whichRotation = 0; // 0 for noone, 1 for right, 1 for left
    void FixedUpdate()
    {
        if (turn)
        {
            if (!soundActive)
            {
                idleSound.Play();
                soundActive = true;
            }
            smoke.SetActive(true);
            frontLights.SetActive(true);
            backLights.SetActive(true);

            if (Input.GetKey("d"))
            {
                Vector3 temp = car.eulerAngles;
                temp.y += 30.0f;
                carLeft.rotation = Quaternion.Euler(temp);
                carRight.rotation = Quaternion.Euler(temp);
            }
            else if (Input.GetKey("a"))
            {
                Vector3 temp = car.eulerAngles;
                temp.y += -30.0f;
                carLeft.rotation = Quaternion.Euler(temp);
                carRight.rotation = Quaternion.Euler(temp);
            }
            else
            {

                Vector3 temp = car.eulerAngles;
                temp.y += 0.0f;
                carLeft.rotation = Quaternion.Euler(temp);
                carRight.rotation = Quaternion.Euler(temp);
            }

            //if (Input.GetKey("w"))
            if (Input.GetButton("Forward")) 
            {
                //smoke.SetActive(true);
                gasSmoke.SetActive(true);
                transform.Translate(forward * speed * Time.deltaTime);
                if (Input.GetKey("d"))
                {
                    Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
                    rb.MoveRotation(rb.rotation * deltaRotationRight);
                }

                if (Input.GetKey("a"))
                {
                    Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
                    rb.MoveRotation(rb.rotation * deltaRotationLeft);
                }
            }
            else if (Input.GetKey("s"))
            {
                gasSmoke.SetActive(false);
                //smoke.SetActive(true);
                transform.Translate(backward * speed * Time.deltaTime);
                if (Input.GetKey("a"))
                {
                    Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
                    rb.MoveRotation(rb.rotation * deltaRotationRight);
                }

                if (Input.GetKey("d"))
                {
                    Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
                    rb.MoveRotation(rb.rotation * deltaRotationLeft);
                }
            }
            else
            {
                gasSmoke.SetActive(false);
            }
        }
        else
        {
            soundActive = false;
            idleSound.Stop();
            smoke.SetActive(false);
            gasSmoke.SetActive(false);
            frontLights.SetActive(false);
            backLights.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "car")
        {
            turn = false;
            GameObject audioM = GameObject.Find("AudioHandler");
            AudioManager aManager = (AudioManager)audioM.GetComponent(typeof(AudioManager));
            aManager.carCrashTurnOn();
        }
        if (collision.gameObject.tag == "environment")
        {
            turn = false;
            GameObject audioM = GameObject.Find("AudioHandler");
            AudioManager aManager = (AudioManager)audioM.GetComponent(typeof(AudioManager));
            aManager.carCrashTurnOn();
        }

    }
}

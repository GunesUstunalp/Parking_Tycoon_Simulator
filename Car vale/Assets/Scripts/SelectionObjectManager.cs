using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionObjectManager : MonoBehaviour
{
    // Update is called once per frame
   // [SerializeField] private Material highlightMaterial;
    //GameObject car;
    CarMovement cM;
   // private bool firstTime = false;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
            var selection = hit.transform.gameObject.tag;
            if(selection == "car")
            {
               // Debug.Log("Car bulundu");
                selection = hit.transform.gameObject.name;
               // Debug.Log("selection name " + selection);
               if(cM != null)
                {
                    cM.turn = false;
                }
                GameObject car = hit.transform.gameObject;
                cM = (CarMovement)car.GetComponent(typeof(CarMovement));
                cM.turn = true;
                GameObject audioM = GameObject.Find("AudioHandler");
                AudioManager aManager = (AudioManager)audioM.GetComponent(typeof(AudioManager));
                aManager.carEnterTurnOn();
            }
            // car = hit.collider.GetComponent() as gameObject;
            // Debug.Log(car.name + " name ");
        }
    }
}

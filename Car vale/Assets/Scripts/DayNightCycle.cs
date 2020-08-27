using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float timeMultiplier = 30f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, timeMultiplier * Time.deltaTime, 0f);
        
    }
}

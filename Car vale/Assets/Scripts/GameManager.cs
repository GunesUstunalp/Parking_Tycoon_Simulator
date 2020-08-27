using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int time = 0;
    public float timeFloatingVersion = 0.0f;
    private float totalMoney = 0.0f;
    private int day = 1; // savelenicek
    public float timeMultiplier = 0.1f;
    private int hours;
    private int minutes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounting();
    }

    private void timeCounting()
    {
        timeFloatingVersion += (Time.deltaTime * timeMultiplier);
        time = (int)timeFloatingVersion;
        //Debug.Log(time);
    }
}

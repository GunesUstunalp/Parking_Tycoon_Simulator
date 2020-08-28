using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public bool wPress = false;
    public bool sPress = false;
    public bool aPress = false;
    public bool dPress = false;

    public void wPressTrue()
    {
        wPress = true;
    }
    public void wPressFalse()
    {
        wPress = false;
    }

    public bool getW()
    {
        return wPress;
    }
    public void sPressTrue()
    {
        sPress = true;
    }
    public void sPressFalse()
    {
        sPress = false;
    }

    public bool getS()
    {
        return sPress;
    }
    public void aPressTrue()
    {
        aPress = true;
    }
    public void aPressFalse()
    {
        aPress = false;
    }

    public bool getA()
    {
        return aPress;
    }
    public void dPressTrue()
    {
        dPress = true;
    }
    public void dPressFalse()
    {
        dPress = false;
    }

    public bool getD()
    {
        return dPress;
    }
}

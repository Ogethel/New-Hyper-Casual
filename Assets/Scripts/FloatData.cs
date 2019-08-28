using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float number)
    {
        value += number; //Take the value, add the new value to it (+) and assign (=) the new value to the variable
    }

}

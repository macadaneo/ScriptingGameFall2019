using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 1;

    public void UpdateValue(int number)
    {
        value += number;
    }
}

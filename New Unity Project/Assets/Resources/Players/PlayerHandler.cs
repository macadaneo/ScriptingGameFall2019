using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PlayerHandler : ScriptableObject
{
    public PlayerData playerDataObj;

    public void SwitchPlayer(PlayerData data)
    {
        playerDataObj = data;
    }

    public void OnRun()
    {
        playerDataObj.Run()
    }
}

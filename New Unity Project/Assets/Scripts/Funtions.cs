using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funtions : MonoBehaviour
{
    public string playerName;
    private int myNumber;
    public GameObject player;
    public float speed = 5f;
    public Color playerColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        ConfigGameObject();
    }

    private GameObject ConfigGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        newPlayer.active = true;
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
        
        return newPlayer;
    }

    private float IncreaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(multiplier: 2f);
    }

    private string WelcomePlayer()
    {
        //Add player to database;
        //give player weapons;
        return playerName + ", Welcome to the Game!";
    }
    
    private int AddNumbers(int a, int b)
    {
        print(a+b);
        return a + b;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player
{

    public string playerName;
    public int health;

    public static int playerCount = 0;



    public void InitialiizePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;

    }
    public void Heal(int amount)
    {
        health = health + amount;
        Debug.Log(health);
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log(health);
        }
    }
    static public void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }

}

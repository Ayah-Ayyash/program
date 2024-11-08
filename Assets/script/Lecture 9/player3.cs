using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3
{
    public string name;
    public int health = 0;
    public static int playerCount;
    public player3(string name, int health)
    {
        this.name = name;
        this.health = health;
        playerCount++;
    }
    public player3() : this("", 100)
    {
        // this.name = "";
        // health = 100;
        // playerCount++;
    }
}

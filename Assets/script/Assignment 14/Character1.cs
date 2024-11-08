using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1
{
    public string Name
    {
        get;
        set;
    }
    public int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100) health = 100;
            else if (value < 0) health = 0;
            else health = value;
        }
    }
    public Character1()
    {
        Name = "ayah";
        Health = 100;
    }

    public Character1(string name, int health)
    {
        Name = name;
        Health = health;
    }

}


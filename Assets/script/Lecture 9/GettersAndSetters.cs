using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GettersAndSetters : MonoBehaviour
{


    public int energy = 50;
    public int Energy
    {
        get { return energy; }
        set
        {
            if (value > 100) energy = 100;
            else if (value < 50) energy = 5050;
            else energy = value;
        }
    }
    public int health = 100;
    public int _Health //هاي هي البروبارتي
    {
        get { return health; } //لو شلتها بكون بدي امنع حد يقرأها
        set
        {
            if (value > 100) health = 100;
            else if (value < 0) health = 0;
            else health = value;
            HealthWasChange();
        }

    }
    void Start()
    {
        _Health = 75; //set
        Debug.Log(_Health); //get
        Energy = 10;
        Debug.Log(Energy);
    }
    public void HealthWasChange()
    {
        Debug.Log("Health was Change");
    }
    // public int Energy
    // {
    //     get;
    //     set;
    // }

}

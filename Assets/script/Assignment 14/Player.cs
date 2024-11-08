using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Character1
{
  
    public void Heal(int amount)
    {
        Health += amount;
      
    }
}
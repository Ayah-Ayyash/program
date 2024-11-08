using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController 
{
   
    void Start()
    {
        Dog dog = new Dog();
        dog.Name = "Jak";
        dog.Move();
        dog.Bark();
    }

   
}

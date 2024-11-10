using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Character1
{
public void Attack(Character target
/*هادي حليتها من الانترنت ، ميصحش*/ , int damage){
     damage= Math.Abs(damage);
     if(target.Health <= Math.Abs(damage)){
          target.Health=0;
     }
     else {
          target.Health-= Math.Abs(damage);
     }
     Debug.Log(nameof + "Attacked " + target.Name + "with damage" +target.Health);
}
}

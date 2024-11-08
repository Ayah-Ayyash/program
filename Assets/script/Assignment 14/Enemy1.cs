using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Character1
{
public void Attack(Character1 A/*هادي حليتها من الانترنت ، ميصحش*/ , int damage){
     A.Health -= damage;
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Ayah", 70);
        Enemy1 enemy = new Enemy1("Ayyash", 90);

        Debug.Log("Player Name: " + player.Name + ";Health: " + player.Health);
        Debug.Log("Enemy Name: " + enemy.Name + ";Health: " + enemy.Health);

        player.Heal(63);
        Debug.Log("New Health: " + player.Health);

        enemy.Attack(player, 20);
        Debug.Log("New Health: " + player.Health);
    }

   
}

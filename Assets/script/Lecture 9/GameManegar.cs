using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManegar : MonoBehaviour
{

    player3 ayah = new player3("shahed", 100);
    player3 Joha = new player3();


    void Start()
    {
        // ayah.InitializePlayer("shahed", 100);
        // Debug.Log(ayah.name + " " + ayah.health);
        // ayah.InitializePlayer("Hosam", 90);
        // ayah.InitializePlayer("Ali", 80);
        // //عملت تلات نسخ
        // Joha.name="soso"; Joha.health=50;
        // Debug.Log(ayah.name + ayah.health);
        // Debug.Log(player3.playerCount);
        Debug.Log(Joha.name + " " + Joha.health);
    }


}

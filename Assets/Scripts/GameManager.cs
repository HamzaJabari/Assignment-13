using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitialiizePlayer("xKiller", 100);
        player2.InitialiizePlayer("DrStone", 75);


        player1.Heal(20);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinner : MonoBehaviour
{

    public int playerWin = 0;
    public GameObject player1;
    public GameObject player2;

    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        playerWin = PlayerPrefs.GetInt("Player");

        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);

        if (playerWin == 1) player1.gameObject.SetActive(true);
        if (playerWin == 2) player2.gameObject.SetActive(true);
    }

}

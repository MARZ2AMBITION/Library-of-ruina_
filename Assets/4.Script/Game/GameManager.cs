using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    PlayerDice playerDice;
    [SerializeField]
    AnemyDice anemyDice;
    [SerializeField]
    GameObject StartButton;

    public void GameStart()
    {
        playerDice.PlayerDiceRoll();
        anemyDice.AnemyDiceRoll();
        StartButton.SetActive(false);
    }
}

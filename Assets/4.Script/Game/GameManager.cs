using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public List<Card> deck = new List<Card>();
    public Transform[] cardSolts;
    public bool[] avilableCardSlotos;

    public Text deckSizeText;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            Card randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < avilableCardSlotos.Length; i++)
            {
                if (avilableCardSlotos[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSolts[i].position;
                    avilableCardSlotos[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }

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

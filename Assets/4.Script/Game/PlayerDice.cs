using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDice : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI PlayerDice1;
    [SerializeField]
    TextMeshProUGUI PlayerDice2;

    public void PlayerDiceRoll()
    {
        int a = Random.Range(2, 8);
        int b = Random.Range(2, 8);

        int dice1 = Mathf.Max(a, b);
        int dice2 = Mathf.Min(a, b);

        PlayerDice1.text = dice1.ToString();
        PlayerDice2.text = dice2.ToString();
    }
}

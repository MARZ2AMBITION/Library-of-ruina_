using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnemyDice : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI AnemyDice1;
    [SerializeField]
    TextMeshProUGUI AnemyDice2;

    public void AnemyDiceRoll()
    {
        int a = Random.Range(4, 7);
        int b = Random.Range(4, 7);

        int dice1 = Mathf.Max(a, b);
        int dice2 = Mathf.Min(a, b);

        AnemyDice1.text = dice1.ToString();
        AnemyDice2.text = dice2.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField] SpriteRenderer card;
    [SerializeField] SpriteRenderer Character;
    [SerializeField] TMP_Text nameTMP;
    [SerializeField] TMP_Text costTMP;
    [SerializeField] TMP_Text attackTMP;
    [SerializeField] TMP_Text attack2TMP;
    [SerializeField] TMP_Text attack3TMP;
    [SerializeField] TMP_Text shieldTMP;
    [SerializeField] Sprite cardFront;

    public Item item;
    bool isfront;

    public void Setup(Item item,bool isFront)
    {
        this.item = item;
        this.isfront = isfront;

        if(this.isfront)
        {
            Character.sprite = this.item.sprite;
            nameTMP.text = this.item.name;
            attackTMP.text = this.item.attack.ToString();
            shieldTMP.text = this.item.shield.ToString();

        }
        else
        {
            card.sprite = cardBack;
            nameTMP.text = "";
            attackTMP.text = "";
            shieldTMP.text = "";
        }
    }
    public void MoveTransfrom()
    {
    
    }


}

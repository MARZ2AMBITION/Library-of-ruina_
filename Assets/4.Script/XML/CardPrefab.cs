using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class CardPrefab : MonoBehaviour
{
    public Text cardNameText; // 카드 이름을 표시할 Text 컴포넌트

    public void SetCardName(string cardName)
    {
        cardNameText.text = cardName; // 텍스트를 Text 컴포넌트에 할당
    }
}


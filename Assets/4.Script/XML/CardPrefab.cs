using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class CardPrefab : MonoBehaviour
{
    public Text cardNameText; // ī�� �̸��� ǥ���� Text ������Ʈ

    public void SetCardName(string cardName)
    {
        cardNameText.text = cardName; // �ؽ�Ʈ�� Text ������Ʈ�� �Ҵ�
    }
}


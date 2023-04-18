using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{

    public static CardManager Inst { get; private set; }
    private void Awake() => Inst = this;
    [SerializeField] itemSO itemSO;
    [SerializeField] GameObject cardprefeb;
    [SerializeField] List<Card> mycard;
    [SerializeField] List<Card> otherCard;

    List<item> itemBuffer;

    void SetitemBuffer()
    {
        itemBuffer = new List<item>();
        for (int i=0; i< itemSO.items.Length;i++)
        {
            item item = itemSO.items[i];
            for (int j = 0; j < item.ATK; j++)
                itemBuffer.Add(item);
        }
        for (int i=0; i<itemBuffer.Count; i++)
        {
            int rand = Random.Range(i, itemBuffer.Count);
            item temp = itemBuffer[i];
            itemBuffer[i] = itemBuffer[rand];
            itemBuffer[rand] = temp;
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        SetitemBuffer();
    }

}

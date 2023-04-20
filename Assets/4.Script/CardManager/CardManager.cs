using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Inst { get; private set; }
    private void Awake() => Inst = this;

    [SerializeField] itemSO itemSO;

    List<Item> itemBuffer;

    public Item popItem()
    {
        if (itemBuffer.Count == 0)
            setupItemBuffer();

        Item item = itemBuffer[0];
        itemBuffer.RemoveAt(0);
        return item;
    }
    void setupItemBuffer()
    {
        itemBuffer = new List<Item>();
        for (int i=0; i<itemSO.items.Length;i++)
        {
            Item item = itemSO.items[i];
            for (int j = 0; j < item.percent; j++)
                itemBuffer.Add(item);
        }
        for (int i =0; i <itemBuffer.Count;i++)
        {
            int rand = Random.Range(i, itemBuffer.Count);
            Item temp = itemBuffer[i];
            itemBuffer[i] = itemBuffer[rand];
            itemBuffer[rand] = temp;
        }
    }
    void Start()
    {
        setupItemBuffer();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
            print(popItem().name);
    }
}

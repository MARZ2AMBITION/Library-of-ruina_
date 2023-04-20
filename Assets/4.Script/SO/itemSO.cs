using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{ 
        public string name;
        public int attack;
        public int health;
        public Sprite sprite;
        public float percent;    
}

[CreateAssetMenu(fileName = "itemSO",menuName = "Sciptable OBject/itemSO")]
public class itemSO : ScriptableObject
{
    public Item[] items;
}
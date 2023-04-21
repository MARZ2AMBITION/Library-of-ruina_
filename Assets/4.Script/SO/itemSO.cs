using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{ 
        public string name;
        public int attack;
        public int attack2;
        public int attack3;
        public int shield;
        public Sprite sprite;
        public float percent;    
}

[CreateAssetMenu(fileName = "itemSO",menuName = "Sciptable OBject/itemSO")]
public class itemSO : ScriptableObject
{
    public Item[] items;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class ScriptableItem : ScriptableObject
{
    public enum IteMType
    {
        Weapon,
        Armor,
        Shield
    }

    public string itemName;

    public string itemDescription;
    public int itemPrice;
    public Sprite itemSprite;
}

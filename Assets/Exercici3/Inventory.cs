using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Item> itemInventory;
    [SerializeField] private Item currentItem;
    private void Awake()
    {
        currentItem = itemInventory[Random.Range(0, itemInventory.Count)];
        currentItem.UseItem();
    }
    /*
    public void UseItemInventory()
    {
        currentItem.UseItem();
    }*/
}

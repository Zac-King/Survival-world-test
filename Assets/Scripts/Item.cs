using UnityEngine;
using System.Collections;

public class Item 
{

    public string itemName;
    public int itemID;
    public bool itemStack;
    public int itemCurrentStack;
    public int itemMaxStack;

    public Item(string name, int id, bool stack, int maxStack)
    {
        itemName = name;
        itemID = id;
        itemStack = stack;
        itemCurrentStack = 1;
        itemMaxStack = maxStack;
    }


}

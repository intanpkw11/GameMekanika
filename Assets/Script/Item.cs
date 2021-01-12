using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int cost;
    public string itemname;

    public void bought()
    {
        if(GetComponentInParent<shop>().moneyAmount >= cost)
        {
            GetComponentInParent<shop>().moneyAmount -= cost;
            GetComponentInParent<shop>().additem(itemname);
        }
    }
}
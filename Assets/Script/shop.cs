using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public float moneyAmount;
    public Text moneytext;
    public Text inventory;
    public float pointPerHour;
    //public float playerInventory;

    //For initialization
    void Start()
    {
        moneyAmount = 5000f;
        //pointPerHour = 50f;
    }

    //Called once per frame
    void Update()
    {
        moneyAmount += pointPerHour * Time.deltaTime;
        moneytext.text = moneyAmount.ToString();
        //inventory.text = playerInventory.ToString();
    }

    public void additem(string item)
    {
        moneytext.text = moneyAmount.ToString();
        inventory.text += "\n" + item;   
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    //Code by: Zyger

    /*
     * Code Notes:
     * Connects text in Visual Studios to an UI.text in Unity.
     * Prints amount of money it takes to buy an item based off the cost in the class ShopManager.
     */

    public int ItemID;
    public Text PriceTxt;
    public GameObject ShopManager;


    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
    }
}

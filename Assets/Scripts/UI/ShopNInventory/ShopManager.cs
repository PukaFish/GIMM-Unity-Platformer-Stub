using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    //Code by: Zyger
    /*
     * Code Notes:
     * Calls upon a multidimensional array that indexes the ID of item, Price of item, and Quantity Bought.
     * Formatted as this: [What information it's storing, Item index]
     * 
     * Buy: Calls upon the EventSystem (UnityEngine.EventSystems) which processes and handle events.
     * In this case, it finds the buttons tied to specific IDs and puts it into a unique variable called ButtonRef.
     * We then take our currency (called "coinAmount" though it takes form of fruits) from the class "ScoreCounter" and make sure we have enough to buy items
     * If we have enough, our quantity increases and our ScoreCounter is subtracted from that amount.
     * If we do not have enough, nothing will happen.
     */

    public AudioClip coin;
    public int [,] shopItems = new int [4, 10];
    public bool canBuy = false;

    // Start is called before the first frame update
    void Start()
    {
        //if (PlayerPrefs.GetInt("inventoryInit") == 0)
        {
            //IDs
            shopItems[1, 1] = 1; //Espresso [x,1] (Bought from EM)
            shopItems[1, 2] = 2; //Madele [x,2] (Bought from EM)
            shopItems[1, 3] = 3; //Coffee [x,3] (Bought from EM)
            shopItems[1, 4] = 4; //Cookie [x,4]] (Bought from EM)
            shopItems[1, 5] = 5; //Magic Gem [x, 5] (Bought from Yun)
            shopItems[1, 6] = 6; //Whoopie Cushion [x,6] (Bought from Yun)
            shopItems[1, 7] = 7; // Normal Book [x,7] (Bought from Yun)
            shopItems[1, 8] = 8; // Exorcist Amulet [x,8] (Bought from Yun)

            //Price
            shopItems[2, 1] = 5;
            shopItems[2, 2] = 5;
            shopItems[2, 3] = 10;
            shopItems[2, 4] = 10;
            shopItems[2, 5] = 20;
            shopItems[2, 6] = 15;
            shopItems[2, 7] = 10;
            shopItems[2, 8] = 30;

            //Quantity
            shopItems[3, 1] = 0;
            shopItems[3, 2] = 0;
            shopItems[3, 3] = 0;
            shopItems[3, 4] = 0;
            shopItems[3, 5] = 0;
            shopItems[3, 6] = 0;
            shopItems[3, 7] = 0;
            shopItems[3, 8] = 0;
        }

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        print(ButtonRef);

        if(ScoreCounter.coinAmount >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            GetComponent<AudioSource>().clip = coin;
            GetComponent<AudioSource>().Play();
            Debug.Log("Item Bought!");
            ScoreCounter.coinAmount -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            canBuy = true;
            
        }
        else if(ScoreCounter.coinAmount < shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            Debug.Log("You couldn't buy");
            FindObjectOfType<DialogueTrigger>().readDialogue = false;
            FindObjectOfType<DialogueTrigger>().TriggerDialouge();
            canBuy = false;
        }
    }
}

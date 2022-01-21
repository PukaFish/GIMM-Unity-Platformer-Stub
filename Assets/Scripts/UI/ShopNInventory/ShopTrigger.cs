using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    /*
     * Coding Notes:
     * Triggers the shop menu if the character bumps into either shop keeper (Tag: EM || Yun). 
     * Closes shop when player bumps into an invisible wall outside of the shop keeper's area. (Tag: Exit)
     * Forces animation to play with animator.Play();
     */
    
    //coffee shop
    public Animator animator;
    public GameObject CST;
    //magic shop
    public Animator animator2;
    public GameObject MST;

    void Start()
    {
        CST = GameObject.Find("CoffeeShopTem");
        animator = CST.GetComponent<Animator>();

        MST = GameObject.Find("MagicShopTem");
        animator2 = MST.GetComponent<Animator>();
    }

   public void OnTriggerEnter2D(Collider2D coll)
   {
       string tagName = coll.gameObject.tag;
       if (tagName == "EM")
       {
           //Debug.Log("Hit");
           animator.Play("LoadShop_EM");
           animator.SetBool("IsOpens", true);
       }
       else if(tagName == "Yun")
        {
            animator2.Play("OpenShop_Yun");
            animator2.SetBool("IsOpen2", true);
        }
   }

    public void OnTriggerExit2D(Collider2D coll)
   {
       string tagName = coll.gameObject.tag;
       if (tagName == "Exit")
       {
           //Debug.Log("Hit");
           animator.Play("CloseShop_EM");
           animator.SetBool("IsOpens", false);
           animator2.Play("CloseShop_Yun");
           animator2.SetBool("IsOpen2", false);
        }
   }
}

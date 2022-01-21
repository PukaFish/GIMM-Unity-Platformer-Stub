using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel_Behavoir : MonoBehaviour
{
    //public GameObject squirrel;
    public Animator squirrelRun;
    public bool hashit = false;

    // Start is called before the first frame update
    void Start()
    {
        //squirrel = GameObject.Find("Squirrel");
        squirrelRun = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("Hit");
        string tagName = coll.collider.gameObject.tag;
        if (tagName == "Wall")
        {
            Destroy(gameObject);
        }
        if (tagName == "Player" && ScoreCounter.coinAmount > 10 && hashit == false)
        {
            ScoreCounter.coinAmount--;
            hashit = true;
        }

    }
}

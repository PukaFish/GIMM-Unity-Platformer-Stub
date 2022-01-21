using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Behavoir : MonoBehaviour
{
    public Animator birdFly;
    
    // Start is called before the first frame update
    void Start()
    {
        birdFly = GetComponent<Animator>();
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

    }
}

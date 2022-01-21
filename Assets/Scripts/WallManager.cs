using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        string tagName = coll.collider.gameObject.tag;
        if (tagName == "enemy")
        {
            Destroy(coll.collider.gameObject);
        }

    }
}

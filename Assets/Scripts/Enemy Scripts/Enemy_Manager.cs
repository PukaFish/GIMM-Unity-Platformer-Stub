using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : MonoBehaviour
{
    // Code written based of tower defense base and mentor help
    public GameObject squirrel;
    public GameObject spawn1;
    private Vector3 sp1;
    public Vector2 sp2;
    public int counter;
    private int maxCounter;

    // Start is called before the first frame update
    void Start()
    {
        sp1 = spawn1.transform.position;
        maxCounter = counter;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= 0 && squirrel != null)
        {
            //Debug.Log(spawn1.transform.position);
            sp2 = new Vector2(sp1.x = 0, sp1.y = 0);
            GameObject squir = Instantiate(squirrel, sp2, Quaternion.identity);
            counter = maxCounter;
        }
        else
        {
            --counter;
        }
    }
   
}

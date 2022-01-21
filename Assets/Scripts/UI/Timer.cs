using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    /*
     * Coding Notes: 
     * Sets timer for different senarios and counts down. Will trigger the next scene ones time is up.
     */

    float timer;
    float timer2;
    float timer3;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        //Offical Times
        timer = 90;
        timer2 = 45;
        timer3 = 45;
        seconds = 0;

        //Testing Times
        //timer = 15;
        //timer2 = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if((SceneManager.GetActiveScene().name == "MiniGame_Time"))
        {
            timer -= Time.deltaTime;
            seconds = (int)(timer);
            GameObject.Find("timerUI").GetComponent<Text>().text = "Time: " + seconds;
        }

        if ((SceneManager.GetActiveScene().name == "Town_Buy"))
        {
            timer2 -= Time.deltaTime;
            seconds = (int)(timer2);
            GameObject.Find("timerUI").GetComponent<Text>().text = "Time: " + seconds;
        }

        if ((SceneManager.GetActiveScene().name == "CSC_Town"))
        {
            timer3 -= Time.deltaTime;
            seconds = (int)(timer3);
            GameObject.Find("timerUI").GetComponent<Text>().text = "Time: " + seconds;
        }

        if (seconds <= 0)
        {
           if (SceneManager.GetActiveScene().name == "MiniGame_Time")
           {
                SceneManager.LoadScene("CutScene_3");
           }
           else if(SceneManager.GetActiveScene().name == "Town_Buy")
           {
                SceneManager.LoadScene("CutScene_6");
           }
           else if (SceneManager.GetActiveScene().name == "CSC_Town")
            {
                SceneManager.LoadScene("SCS_4");
            }

            /*if (SceneManager.GetActiveScene().name == "MiniGame_Time")
            {
                SceneManager.LoadScene("Town_Buy");
            }
            else if (SceneManager.GetActiveScene().name == "Town_Buy")
            {
                SceneManager.LoadScene("Inventory_Scene");
            }*/
        }
    }
}
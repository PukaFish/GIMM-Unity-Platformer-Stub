using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class coinAmountSpend : MonoBehaviour
{
    public ScoreCounter score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("scoreUI").GetComponent<Text>().text = "Score: " + score;

    }
}

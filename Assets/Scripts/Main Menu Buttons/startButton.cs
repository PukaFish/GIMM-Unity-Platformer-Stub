using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {
        //PlayerPrefs.SetInt("inventoryInit", 0);
        SceneManager.LoadScene("CutScene_1");
        ScoreCounter.coinAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

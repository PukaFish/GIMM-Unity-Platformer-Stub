using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public PlatformManager platformManagerScript;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            ScoreCounter.coinAmount += 1;
                
            if(ScoreCounter.coinAmount <= 5)
            {
                platformManagerScript.NewPlatform();
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrailerButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("TrailerIntro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

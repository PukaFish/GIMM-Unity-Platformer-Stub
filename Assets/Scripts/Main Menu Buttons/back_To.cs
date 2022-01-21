using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_To : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("splashScreen");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

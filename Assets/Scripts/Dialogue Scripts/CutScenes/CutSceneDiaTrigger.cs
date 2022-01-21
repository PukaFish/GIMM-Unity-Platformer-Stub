using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CutSceneDiaTrigger : MonoBehaviour
{
    //Code from: Brackeys
    public Dialogue dialogueCS;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerDialogueCS()
    {
            FindObjectOfType<CutSceneDiaManager>().StartDialogue(dialogueCS);
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        TriggerDialogueCS();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutSceneDiaManager : MonoBehaviour
{
    //Code from: Brackeys
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        //Debug.Log("Hi");
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;

        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of Convo");

        //Cutscenes
        //if(SceneManager.GetActiveScene().name == "CutScene_1")
        //{
        //SceneManager.LoadScene("MiniGame_Time");
        //}

        if (SceneManager.GetActiveScene().name == "CutScene_1")
        {
            SceneManager.LoadScene("CutScene_2");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_2")
        {
            SceneManager.LoadScene("MiniGame_Time");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_3")
        {
            SceneManager.LoadScene("CutScene_4");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_4")
        {
            SceneManager.LoadScene("CutScene_5");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_5")
        {
            SceneManager.LoadScene("Town_Buy");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_6")
        {
            SceneManager.LoadScene("CutScene_7");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_7")
        {
            SceneManager.LoadScene("CutScene_8");
        }
        // else if (SceneManager.GetActiveScene().name == "CutScene_7")
        // {
        //     SceneManager.LoadScene("Inventory_Scene");
        //}
        else if (SceneManager.GetActiveScene().name == "CutScene_8")
        {
            SceneManager.LoadScene("CutScene_9");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_9")
        {
            SceneManager.LoadScene("CutScene_10");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_10")
        {
            SceneManager.LoadScene("CutScene_11");
        }
        else if (SceneManager.GetActiveScene().name == "CutScene_11")
        {
            SceneManager.LoadScene("Normal_End");
        }


        if (SceneManager.GetActiveScene().name == "SCS_1")
        {
            SceneManager.LoadScene("SCS_2");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_2")
        {
            SceneManager.LoadScene("SCS_3");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_3")
        {
            SceneManager.LoadScene("CSC_Town");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_4")
        {
            SceneManager.LoadScene("SCS_5");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_5")
        {
            SceneManager.LoadScene("SCS_6");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_6")
        {
            SceneManager.LoadScene("SCS_7");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_7")
        {
            SceneManager.LoadScene("SCS_8");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_8")
        {
            SceneManager.LoadScene("SCS_9");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_9")
        {
            SceneManager.LoadScene("SCS_10");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_10")
        {
            SceneManager.LoadScene("SCS_11");
        }
        else if (SceneManager.GetActiveScene().name == "SCS_11")
        {
            SceneManager.LoadScene("Happy_End");
        }
    }

}



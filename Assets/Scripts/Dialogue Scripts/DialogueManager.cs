using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    //Code from: Brackeys + Peer Mentor Help

    /* 
    * Coding Notes:
    * StartDialouge: takes the strings under "sentence" and then use it to fill up the queue "sentences". Also opens textbox.
    * DisplayNextSentence: plays dialouge until there are zero "sentence"s left in queue then calls the method "EndDialogue"
    * EndDialogue: Closes textbox thru animation and then goes into class "DialogueTriger" to affirm the dialogue has been read.
    * 
    * Queue is like an array that is stored in System.Collections, but it has two functions: enqueue and dequeue.
    * Enqueue takes in data in a "first come first serve basis" while Dequeue removes the data.
    * 
    * Coroutines is a function (in UnityEngine) that pauses and execution or returns control to Unity (Unity Documentation)
    * In this case, it is taking each letter (char letter) in the string sentence and making it so that the dialouge is appearing one wrod at a time by adding it in.
    * This is closely correlated with IEnumerator (.Net, automatically in Unity) which does the pausing and returning of Coroutines.
    */

    public Text nameText;
    public Text dialogueText;
    public bool readDialogue;
    public Animator animator;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        readDialogue = false;
    }

    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        //Debug.Log("Hi");
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;

        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of Convo");

        FindObjectOfType<DialogueTrigger>().setRead();
        FindObjectOfType<DialogueTrigger>().dialogueCheck=false;

        if (FindObjectOfType<DialogueTrigger>().dialogueCount == 32)
        {
            SceneManager.LoadScene("SCS_1");
        }
    }
}

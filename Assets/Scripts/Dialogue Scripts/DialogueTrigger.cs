using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DialogueTrigger : MonoBehaviour
{
    //Code from: Brackeys + Peer Mentor Help

    /*
     * Coding Nots: 
     * TriggerDialouge: Calls Class "DialogueManager", gets method to start playing dialouge.
     * Has Four situations: Checks if player read the dialogue, checks if the current scene is the minigame to spawn array of text after main dialgue, and checks if it is town or tutorial so it doesn't spawn stirng array.
     * OnTriggerEnter2D: Class method "TriggerDialogue" when players bump into specific people.
     * setRead: Makes sure you go through main dialogue before it plays any extra dialogue (arrays).
     */

    public Dialogue dialogue;
    public bool readDialogue = false;
    public int dialogueCount = 0;
    private Dialogue elDialogue;
    public string[] elldialogue = new string[1];
    public bool dialogueCheck;

    public ShopManager manager;

    public string[] messageArray = new string[]
    {
        "?",
        "What are you waiting for?",
        "Mother would not like the idea of me climbing in a Ginkgo tree with a dress...",
        "Go brother go!",
        "These fruits won't be able to help mother. We don't even know how to make medicine.",
        "If you give me your pants I would not mind helping you collect fruits.",
        "You can do it brother!",
        "May the heavens bless this fight...",
        "Beware of-- ACK! BIRDS!",
        "Is that a squirrel??",
        "This tree smells...",
        "Ginkgo trees are renowed in China. Although, you'll usually see the male ones.",
        "Where's China? Um, I suppose it's not surprising you haven't heard of it in this world...",
        "Oh nothing!",
        "Female trees are the smelly ones, but they're the only one who gives these fruits.",
        "I heard the Church here values something completely different than what they're branded.",
        "What is it? Uh, something about Thoma from Genshin Impact.",
        "What's Genshin Impact? It's a game.",
        "What type of game? A mobi-- A COLLECTING GAME.",
        "Sorry sorry, I won't slander the church anymore.",
        "May the goddess protect thee.",
        "Not to be rude, but don't you have a job to do?",
        "Hmph...",
        "...",
        "...",
        "...",
        "Fine, I give up. I do love Thoma as much as the church does.",
        "What else would you like to know?",
        "What I think about the goddess? I hope that she will accept the offering to make our parents better.",
        "What do I think about you? I'm glad you are my brother.",
        "I see that there in no intention to stop talking to me.",
        "Here, this is all I have. May the goddess accept it as an offering."
    };

    public void TriggerDialouge()
    {

        if (!readDialogue)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (SceneManager.GetActiveScene().name == "MiniGame_Time")
        {
            //Debug.Log(dialogueCount);
            elldialogue[0] = messageArray[dialogueCount];
            elDialogue = new Dialogue("Elise", elldialogue);
            FindObjectOfType<DialogueManager>().StartDialogue(elDialogue);
            dialogueCount++;
        }
        else if (SceneManager.GetActiveScene().name == "Town_Buy")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }

    }

    //Self Written With Credits To My Sister + Mentors
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (dialogueCheck == false)
        {
            //Debug.Log("Hit");
            TriggerDialouge();
            gameObject.SetActive(true);
            dialogueCheck = true;
           // Debug.Log("Hit");
        }
        
        if (coll.gameObject.CompareTag("EM") || coll.gameObject.CompareTag("Yun"))
        {
            Debug.Log("Hit Shopkeeper");
            TriggerDialouge();
            dialogueCheck = true;
        }

        if (coll.gameObject.CompareTag("Tutorial"))
        {
            //Debug.Log("Hit");
            TriggerDialouge();
            dialogueCheck = true;
        }
    }

    public void buttonBuy()
    {
        if(FindObjectOfType<ShopManager>().canBuy == false)
        {
            Debug.Log("Hitt");
            TriggerDialouge();
        }
    }

    public void setRead()
    {
        readDialogue = true;
    }
}

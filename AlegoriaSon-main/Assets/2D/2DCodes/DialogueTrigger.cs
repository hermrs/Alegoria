using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject Gm;
    public GameObject Hm;
=======
    public GameObject gm;
>>>>>>> Stashed changes
    public Dialogue dialogueScript;
    private bool playerDetected;

    //Detect trigger with player
    private void Start()
    {
        gm = GameObject.Find("G�revController");
    }
    private void OnTriggerEnter(Collider collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if (collision.tag == "Player")
        {
            playerDetected = true;
           
            dialogueScript.ToggleIndicator(playerDetected);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        //If we lost trigger  with the player disable playerdeteced and hide indicator
        if (collision.tag == "Player")
        {
            playerDetected = false;
            dialogueScript.ToggleIndicator(playerDetected);
            dialogueScript.EndDialogue();
        }
    }
    //While detected if we interact start the dialogue
    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.E))
        {
            dialogueScript.StartDialogue();
<<<<<<< Updated upstream
            Gm.gameObject.SetActive(true);  
            Hm.SetActive(true);

=======
            gm.SetActive(true);
>>>>>>> Stashed changes
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public GameObject Gm;
    public GameObject Hm;

    public GameObject gm;

    public Dialogue dialogueScript;
    private bool playerDetected;

    //Detect trigger with player
    private void Start()
    {
        gm = GameObject.Find("GörevController");
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

            Gm.gameObject.SetActive(true);  
            Hm.SetActive(true);


            gm.SetActive(true);

        }
    }
}
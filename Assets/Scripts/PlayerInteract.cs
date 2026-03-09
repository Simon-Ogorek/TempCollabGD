using UnityEngine;
using UnityEngine.InputSystem;
using System;

/// <summary>
/// Deals with player interaction
/// </summary>
public class PlayerInteract : MonoBehaviour
{

    private bool touchingNPC = false;
    private GameObject lastTouchedNPC;

//Update function starts a dialogue action with collided NPC.
    void Update()
    {
        if((touchingNPC && Input.GetKeyDown(KeyCode.I)) || (touchingNPC &&  Gamepad.current.buttonEast.wasPressedThisFrame))
        {
            Debug.Log("Touched NPC");
            lastTouchedNPC.GetComponent<NonCombatant>().GiveDialogue();
            touchingNPC = false;

        }
        
    }


//Trigger collider checks if player is touching an NPC
    void OnTriggerEnter(Collider entity)
    {
        if(entity.tag == "NPC")
        {
            touchingNPC = true;
            lastTouchedNPC = entity.gameObject;
            Debug.Log("NPC Triggered");
        }
    }

    void OnTriggerExit(Collider entity)
    {
        if(entity.tag == "NPC")
        {
            touchingNPC = false;
        }
    }
}

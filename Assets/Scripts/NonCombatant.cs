using System;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using UnityEngine;

/// <summary>
/// Entities that are noncombatants
/// </summary>
public class NonCombatant : MonoBehaviour
{

//Array with all of the dialogue of the NPC
    [SerializeField]
    protected string[] dialogue;

    int i = 0;
    bool inDialogue = false;

    void Start()
    {
        
    }

//Goes through dialogue array
    void Update()
    {
        if(inDialogue)
        {
        if(i < dialogue.Length)
        {
            if(Input.GetKeyDown(KeyCode.I) || Gamepad.current.buttonEast.wasPressedThisFrame)
            {
                i+=1;
                if(i<=dialogue.Length-1)
                    UIController.Instance.OpenDialogue(dialogue[i]);
            }

            
        }
        else
            {
                inDialogue = false;
                UIController.Instance.EndDialogue();
            }
        }
    }

//Starts a dialogue action from UI Controller
    public void GiveDialogue()
    {
        i = 0;
        UIController.Instance.OpenDialogue(dialogue[i]);
        inDialogue = true;
    }
}
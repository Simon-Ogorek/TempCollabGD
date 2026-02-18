using UnityEngine;

public class Combatant : MonoBehaviour
{
    //general combatent script for player and eidos partners to build off
    [SerializeField]
    protected float Health = 5f;
    [SerializeField]
    private Transform player;
    [SerializeField]
    protected GameObject partyManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //Player is controlling the selected
    public void SwitchOn()
    {
        gameObject.GetComponent<CharacterController>().enabled = true;
        gameObject.GetComponent<PlayerMovement>().enabled = true;
        gameObject.GetComponent<Follow>().enabled = false;

    }
    //Member is switched to a follower
     public void SwitchOff()
    {
        gameObject.GetComponent<CharacterController>().enabled = false;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        gameObject.GetComponent<Follow>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
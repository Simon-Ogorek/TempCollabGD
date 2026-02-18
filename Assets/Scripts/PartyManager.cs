using UnityEngine;
using Unity.Cinemachine;


public class PartyManager : MonoBehaviour
{

    //PartyManager deals with party and switching between members.
    public enum CurrentMember
    {
        Player,
        Eidos
    }


    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject Eidos;

    [SerializeField]
    private CinemachineCamera Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private CurrentMember selected;
    
    //SwitchMember switches player control from player character to eidos partner.
    public void SwitchMember()
    {
        if(selected == CurrentMember.Player){
            Player.GetComponent<PlayerBattle>().SwitchOff();
            Eidos.GetComponent<EidosBattle>().SwitchOn();
            Debug.LogWarning("Switch to Eidos");

            Camera.Follow = Eidos.transform;
            selected = CurrentMember.Eidos;}
        else if(selected == CurrentMember.Eidos){
            Eidos.GetComponent<EidosBattle>().SwitchOff();
            Player.GetComponent<PlayerBattle>().SwitchOn();
            Debug.LogWarning("Switch to Player");

            Camera.Follow = Player.transform;    
            selected = CurrentMember.Player;}
    } 
    void Start()
    {
        selected = CurrentMember.Player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

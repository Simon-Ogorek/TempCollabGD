using UnityEngine;

[CreateAssetMenu(menuName = "Combat/Effects/Damage")]
public class DamageEffect : MoveEffect
{

    public override void Apply(Combatant user, MoveData data)
    {
        Debug.Log("Imagine there is a cool punch visual and audio effect in the code here");
        user.target.ChangeHealth(data.output);
    }
}
using UnityEngine;

[CreateAssetMenu(menuName = "Combat/Effects/HealSelf")]
public class HealEffect : MoveEffect
{

    public override void Apply(Combatant user, MoveData data)
    {
        user.ChangeHealth(data.output);
    }
}
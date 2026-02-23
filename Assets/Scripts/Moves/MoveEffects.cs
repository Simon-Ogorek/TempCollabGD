using UnityEngine;

public abstract class MoveEffect : ScriptableObject
{
    public abstract void Apply(Combatant user, MoveData data);
}



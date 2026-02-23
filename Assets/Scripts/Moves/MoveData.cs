using System;
using UnityEngine;

public enum targetTypes
{
    Self,
    Enemy,
    Party
}

[CreateAssetMenu(fileName = "NewMove", menuName = "Combat/Move")]
public class MoveData : ScriptableObject
{
    public string moveName;

    public float output;
    public float cooldown;
    public float range;
    public float manaChange;
    public targetTypes targetType;
    public MoveEffect[] effects;

}
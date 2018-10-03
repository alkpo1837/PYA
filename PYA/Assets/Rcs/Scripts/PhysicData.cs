using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PhysicData", menuName = "PYA/PhysicData", order = 1)]
public class PhysicData : ScriptableObject
{
    public enum PhysicType
    {
        Box,
        Square
    };

    public PhysicType Type;
    public Vector2 Position;
    public Vector2 Size;
}

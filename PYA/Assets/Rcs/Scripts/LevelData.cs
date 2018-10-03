using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "PYA/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    public Vector2 SpawnPoint;
    public Vector2 EndPoint;
    public string DecorationPath;
    public string PhysicsData;
}

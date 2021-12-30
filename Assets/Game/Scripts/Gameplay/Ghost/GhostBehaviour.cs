using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class GhostBehaviour : ScriptableObject
{
    public Character Ghost;
    public float Speed;
    public float RespawnTime;

    public abstract Vector3Int GetChasePosition(GameObject p_owner);
}

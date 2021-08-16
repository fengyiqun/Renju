using System;
using Unity.Entities;
using UnityEngine;
public struct SPMesh:ISharedComponentData, IEquatable<SPMesh>
{
    public SpriteRenderer sr;
    public bool Equals(SPMesh obj)
    {
        return true;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

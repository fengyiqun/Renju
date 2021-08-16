using System;
using Unity.Entities;
public struct DirtyDataCom: ISystemStateComponentData
{
    public int state;
    public int currColor;
}

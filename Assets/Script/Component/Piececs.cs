using System;
using Unity.Entities;
using UnityEngine;

public class Piece:IComponentData
{
    //棋子的颜色
    public int Color;
    //棋子的ID；
    public int Index;
    //棋子的坐标
    public Vector2 pos;
}

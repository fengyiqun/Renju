using System;
using Unity.Entities;
using UnityEngine;
public struct CheckerBoard:IComponentData
{
    //棋盘的大小
    public Vector2 Size;
    //当前下的是哪个颜色
    public int CurrentColor;

    public Vector2 plececsPos;

    public int currentIndex;
    //是否结束
    public bool Finish;
    //胜利方
    public int WinColor;
}

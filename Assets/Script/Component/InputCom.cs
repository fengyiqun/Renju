using System;
using Unity.Entities;
using UnityEngine;
public class InputCom:IComponentData
{
    //当前输入的坐标ID
    public int CurrentIndex = 0;
    //当前输入的坐标
    public Vector2 CurrentPos;
    //当前输入的棋子的位置
    public Vector2 BoardPos;
    //棋子的0，0点位置
    public Vector2 ZeroPos = new Vector2(7f,7f);
    //棋格之间的距离
    public float Diff = 1.33f;
    //棋子的颜色
    public int color;

}

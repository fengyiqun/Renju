using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay { 

public class Utils
{
    public static Transform root;
    public static GameObject black;
    public static GameObject white;
    public static bool GetTouch(LuaInterface.LuaTable t)
    {
        if (!Input.GetMouseButtonDown(0))
                return false;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos /= 1.32f;
        worldPos += new Vector2(7, 7);
        int x = Mathf.RoundToInt(worldPos.x);
        int y = Mathf.RoundToInt(worldPos.y);
        if (x < 0 || y < 0 || x > 14 || y > 14)
                return false;
        Debug.Log("GetTouch" + x + ":" + y);
        t.SetTable<int>("x", x);
        t.SetTable<int>("y", y);
        return true;
    }

    public static GameObject PlaceChess(int x, int y, int black_or_white)
    {
        GameObject go;
        float a = 1.32f;
        Vector3 pos = new Vector3();
        pos.x = (x - 7) * a;
        pos.y = (y - 7) * a;
        pos.z = 1;
        go = (black_or_white == 0) ? black : white;
        return Object.Instantiate(go, pos, Quaternion.identity, root);
    }
}

}

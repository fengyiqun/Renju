using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    LuaState lua = null;
    public void Awake()
    {
        lua = new LuaState();
        lua.Start();
        lua.AddSearchPath(LuaConst.luaDir);
        lua.AddSearchPath(LuaConst.toluaDir);
    }
    // Start is called before the first frame update
    void Start()
    {
        lua.DoFile("main.lua");
    }
}

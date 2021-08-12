using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay { 

public class GamePlay : MonoBehaviour
{
    public Transform root;
    public GameObject white;
    public GameObject black;

    LuaState lua = null;
    LuaFunction update = null;
    LuaFunction fixed_update = null;
    public void Awake()
    {
        Utils.root = root;
        Utils.white = white;
        Utils.black = black;
        lua = new LuaState();
        lua.Start();
        LuaBinder.Bind(lua);
        DelegateFactory.Init();   
        lua.AddSearchPath(LuaConst.luaDir);
        lua.AddSearchPath(LuaConst.toluaDir);
        lua.DoFile("main.lua");
        update = lua.GetFunction("Update", true);
        fixed_update = lua.GetFunction("FixedUpdate", true);
    }
    public void Update()
    {
        if (update != null)
            update.Call();
    }
    public void FixedUpdate()
    {
        if (fixed_update != null)
            fixed_update.Call();
    }
}

}
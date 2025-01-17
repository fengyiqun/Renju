﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_RenderSettingsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("RenderSettings");
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegVar("fog", new LuaCSFunction(get_fog), new LuaCSFunction(set_fog));
		L.RegVar("fogStartDistance", new LuaCSFunction(get_fogStartDistance), new LuaCSFunction(set_fogStartDistance));
		L.RegVar("fogEndDistance", new LuaCSFunction(get_fogEndDistance), new LuaCSFunction(set_fogEndDistance));
		L.RegVar("fogMode", new LuaCSFunction(get_fogMode), new LuaCSFunction(set_fogMode));
		L.RegVar("fogColor", new LuaCSFunction(get_fogColor), new LuaCSFunction(set_fogColor));
		L.RegVar("fogDensity", new LuaCSFunction(get_fogDensity), new LuaCSFunction(set_fogDensity));
		L.RegVar("ambientMode", new LuaCSFunction(get_ambientMode), new LuaCSFunction(set_ambientMode));
		L.RegVar("ambientSkyColor", new LuaCSFunction(get_ambientSkyColor), new LuaCSFunction(set_ambientSkyColor));
		L.RegVar("ambientEquatorColor", new LuaCSFunction(get_ambientEquatorColor), new LuaCSFunction(set_ambientEquatorColor));
		L.RegVar("ambientGroundColor", new LuaCSFunction(get_ambientGroundColor), new LuaCSFunction(set_ambientGroundColor));
		L.RegVar("ambientIntensity", new LuaCSFunction(get_ambientIntensity), new LuaCSFunction(set_ambientIntensity));
		L.RegVar("ambientLight", new LuaCSFunction(get_ambientLight), new LuaCSFunction(set_ambientLight));
		L.RegVar("subtractiveShadowColor", new LuaCSFunction(get_subtractiveShadowColor), new LuaCSFunction(set_subtractiveShadowColor));
		L.RegVar("skybox", new LuaCSFunction(get_skybox), new LuaCSFunction(set_skybox));
		L.RegVar("sun", new LuaCSFunction(get_sun), new LuaCSFunction(set_sun));
		L.RegVar("ambientProbe", new LuaCSFunction(get_ambientProbe), new LuaCSFunction(set_ambientProbe));
		L.RegVar("customReflection", new LuaCSFunction(get_customReflection), new LuaCSFunction(set_customReflection));
		L.RegVar("reflectionIntensity", new LuaCSFunction(get_reflectionIntensity), new LuaCSFunction(set_reflectionIntensity));
		L.RegVar("reflectionBounces", new LuaCSFunction(get_reflectionBounces), new LuaCSFunction(set_reflectionBounces));
		L.RegVar("defaultReflectionMode", new LuaCSFunction(get_defaultReflectionMode), new LuaCSFunction(set_defaultReflectionMode));
		L.RegVar("defaultReflectionResolution", new LuaCSFunction(get_defaultReflectionResolution), new LuaCSFunction(set_defaultReflectionResolution));
		L.RegVar("haloStrength", new LuaCSFunction(get_haloStrength), new LuaCSFunction(set_haloStrength));
		L.RegVar("flareStrength", new LuaCSFunction(get_flareStrength), new LuaCSFunction(set_flareStrength));
		L.RegVar("flareFadeSpeed", new LuaCSFunction(get_flareFadeSpeed), new LuaCSFunction(set_flareFadeSpeed));
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fog(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.RenderSettings.fog);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogStartDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.fogStartDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogEndDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.fogEndDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.fogMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogColor(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.fogColor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogDensity(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.fogDensity);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.ambientMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientSkyColor(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.ambientSkyColor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientEquatorColor(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.ambientEquatorColor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientGroundColor(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.ambientGroundColor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientIntensity(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.ambientIntensity);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientLight(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.ambientLight);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_subtractiveShadowColor(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.subtractiveShadowColor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skybox(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.skybox);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sun(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, UnityEngine.RenderSettings.sun);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientProbe(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.RenderSettings.ambientProbe);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_customReflection(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, UnityEngine.RenderSettings.customReflection);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reflectionIntensity(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.reflectionIntensity);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reflectionBounces(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.RenderSettings.reflectionBounces);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultReflectionMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.RenderSettings.defaultReflectionMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultReflectionResolution(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.RenderSettings.defaultReflectionResolution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_haloStrength(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.haloStrength);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flareStrength(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.flareStrength);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flareFadeSpeed(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.RenderSettings.flareFadeSpeed);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fog(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.RenderSettings.fog = arg0;
			UnityEngine.RenderSettings.fog = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogStartDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.fogStartDistance = arg0;
			UnityEngine.RenderSettings.fogStartDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogEndDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.fogEndDistance = arg0;
			UnityEngine.RenderSettings.fogEndDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogMode(IntPtr L)
	{
		try
		{
			UnityEngine.FogMode arg0 = (UnityEngine.FogMode)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.FogMode>.type);
			UnityEngine.RenderSettings.fogMode = arg0;
			UnityEngine.RenderSettings.fogMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogColor(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.fogColor = arg0;
			UnityEngine.RenderSettings.fogColor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogDensity(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.fogDensity = arg0;
			UnityEngine.RenderSettings.fogDensity = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientMode(IntPtr L)
	{
		try
		{
			UnityEngine.Rendering.AmbientMode arg0 = (UnityEngine.Rendering.AmbientMode)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.Rendering.AmbientMode>.type);
			UnityEngine.RenderSettings.ambientMode = arg0;
			UnityEngine.RenderSettings.ambientMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientSkyColor(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.ambientSkyColor = arg0;
			UnityEngine.RenderSettings.ambientSkyColor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientEquatorColor(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.ambientEquatorColor = arg0;
			UnityEngine.RenderSettings.ambientEquatorColor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientGroundColor(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.ambientGroundColor = arg0;
			UnityEngine.RenderSettings.ambientGroundColor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientIntensity(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.ambientIntensity = arg0;
			UnityEngine.RenderSettings.ambientIntensity = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientLight(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.ambientLight = arg0;
			UnityEngine.RenderSettings.ambientLight = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_subtractiveShadowColor(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			UnityEngine.RenderSettings.subtractiveShadowColor = arg0;
			UnityEngine.RenderSettings.subtractiveShadowColor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skybox(IntPtr L)
	{
		try
		{
			UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckObject<UnityEngine.Material>(L, 2);
			UnityEngine.RenderSettings.skybox = arg0;
			UnityEngine.RenderSettings.skybox = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sun(IntPtr L)
	{
		try
		{
			UnityEngine.Light arg0 = (UnityEngine.Light)ToLua.CheckObject<UnityEngine.Light>(L, 2);
			UnityEngine.RenderSettings.sun = arg0;
			UnityEngine.RenderSettings.sun = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientProbe(IntPtr L)
	{
		try
		{
			UnityEngine.Rendering.SphericalHarmonicsL2 arg0 = StackTraits<UnityEngine.Rendering.SphericalHarmonicsL2>.Check(L, 2);
			UnityEngine.RenderSettings.ambientProbe = arg0;
			UnityEngine.RenderSettings.ambientProbe = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_customReflection(IntPtr L)
	{
		try
		{
			UnityEngine.Cubemap arg0 = (UnityEngine.Cubemap)ToLua.CheckObject<UnityEngine.Cubemap>(L, 2);
			UnityEngine.RenderSettings.customReflection = arg0;
			UnityEngine.RenderSettings.customReflection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reflectionIntensity(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.reflectionIntensity = arg0;
			UnityEngine.RenderSettings.reflectionIntensity = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reflectionBounces(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.RenderSettings.reflectionBounces = arg0;
			UnityEngine.RenderSettings.reflectionBounces = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultReflectionMode(IntPtr L)
	{
		try
		{
			UnityEngine.Rendering.DefaultReflectionMode arg0 = (UnityEngine.Rendering.DefaultReflectionMode)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.Rendering.DefaultReflectionMode>.type);
			UnityEngine.RenderSettings.defaultReflectionMode = arg0;
			UnityEngine.RenderSettings.defaultReflectionMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultReflectionResolution(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.RenderSettings.defaultReflectionResolution = arg0;
			UnityEngine.RenderSettings.defaultReflectionResolution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_haloStrength(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.haloStrength = arg0;
			UnityEngine.RenderSettings.haloStrength = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flareStrength(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.flareStrength = arg0;
			UnityEngine.RenderSettings.flareStrength = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flareFadeSpeed(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.RenderSettings.flareFadeSpeed = arg0;
			UnityEngine.RenderSettings.flareFadeSpeed = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


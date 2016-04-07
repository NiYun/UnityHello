﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LTBezierWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LTBezier), typeof(System.Object));
		L.RegFunction("point", point);
		L.RegFunction("New", _CreateLTBezier);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("length", get_length, set_length);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLTBezier(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
				UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 4);
				float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
				LTBezier obj = new LTBezier(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LTBezier.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int point(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LTBezier obj = (LTBezier)ToLua.CheckObject(L, 1, typeof(LTBezier));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 o = obj.point(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LTBezier obj = (LTBezier)o;
			float ret = obj.length;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index length on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LTBezier obj = (LTBezier)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.length = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index length on a nil value" : e.Message);
		}
	}
}


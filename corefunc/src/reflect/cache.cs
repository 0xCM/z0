//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Concurrent;
using System.Reflection;

using Z0;
using static zfunc;
using static Z0.ReflectionFlags;

partial class zfunc
{
    static ConcurrentDictionary<Type, PropertyInfo[]> _propsCache
        = new ConcurrentDictionary<Type, PropertyInfo[]>();

    static ConcurrentDictionary<Type, ConstructorInfo[]> _constructorCache
        = new ConcurrentDictionary<Type, ConstructorInfo[]>();

    static ConcurrentDictionary<Type, Type> _ulTypeCache
        = new ConcurrentDictionary<Type, Type>();

    static ConcurrentDictionary<Type, Type> _nnTypeCache 
        = new ConcurrentDictionary<Type, Type>();

    static readonly ConcurrentDictionary<MethodInfo, Delegate> Delegates 
        = new ConcurrentDictionary<MethodInfo, Delegate>();
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{
    /// <summary>
    /// Returns generic 0 for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T zero<T>()
        where T : unmanaged
            => default;

    /// <summary>
    /// Returns generic 1 for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T one<T>()
        where T : unmanaged
            => convert<T>(1);

    /// <summary>
    /// Returns the minimum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T minval<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return minval_i<T>();
        else if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return minval_u<T>();
        else
            return minval_f<T>();
    }                

    /// <summary>
    /// Returns the maximum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T maxval<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return maxval_i<T>();
        else if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return maxval_u<T>();
        else
            return maxval_f<T>();
    }                


    [MethodImpl(Inline)]
    static T minval_i<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return convert<T>(sbyte.MinValue);
        else if(typeof(T) == typeof(short))
            return convert<T>(short.MinValue);
        else if(typeof(T) == typeof(int))
            return convert<T>(int.MinValue);
        else
            return convert<T>(long.MinValue);
    }

    [MethodImpl(Inline)]
    static T minval_u<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return convert<T>(byte.MinValue);
        else if(typeof(T) == typeof(ushort))
            return convert<T>(ushort.MinValue);
        else if(typeof(T) == typeof(uint))
            return convert<T>(uint.MinValue);
        else
            return convert<T>(ulong.MinValue);
    }

    [MethodImpl(Inline)]
    static T minval_f<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            return convert<T>(float.MinValue);
        else if(typeof(T) == typeof(double))
            return convert<T>(double.MinValue);
        else
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    static T maxval_i<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return convert<T>(sbyte.MaxValue);
        else if(typeof(T) == typeof(short))
            return convert<T>(short.MaxValue);
        else if(typeof(T) == typeof(int))
            return convert<T>(int.MaxValue);
        else
            return convert<T>(long.MaxValue);
    }

    [MethodImpl(Inline)]
    static T maxval_u<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return convert<T>(byte.MaxValue);
        else if(typeof(T) == typeof(ushort))
            return convert<T>(ushort.MaxValue);
        else if(typeof(T) == typeof(uint))
            return convert<T>(uint.MaxValue);
        else
            return convert<T>(ulong.MaxValue);
    }

    [MethodImpl(Inline)]
    static T maxval_f<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            return convert<T>(float.MaxValue);
        else if(typeof(T) == typeof(double))
            return convert<T>(double.MaxValue);
        else
            throw unsupported<T>();
    }

}
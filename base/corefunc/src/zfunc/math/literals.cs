//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{       
    /// <summary>
    /// The zero-value for an 8-bit signed integer
    /// </summary>
    public const sbyte z8i = 0;

    /// <summary>
    /// The zero-value for an 8-bit usigned integer
    /// </summary>
    public const byte z8 = 0;

    /// <summary>
    /// The 0-value for a 16-bit signed integer
    /// </summary>
    public const short z16i = 0;

    /// <summary>
    /// The 0-value for a 16-bit unsigned integer
    /// </summary>
    public const ushort z16 = 0;

    /// <summary>
    /// The zero-value for a 32-bit signed integer
    /// </summary>
    public const int z32i = 0;

    /// <summary>
    /// The zero-value for a 32-bit usigned integer
    /// </summary>
    public const uint z32 = 0;

    /// <summary>
    /// The zero-value for a 64-bit signed integer
    /// </summary>
    public const long z64i = 0;

    /// <summary>
    /// The zero-value for a 64-bit usigned integer
    /// </summary>
    public const ulong z64 = 0;

    /// <summary>
    /// The zero-value for a 32-bit float
    /// </summary>
    public const float z32f = 0;

    /// <summary>
    /// The zero-value for a 64-bit float
    /// </summary>
    public const double z64f = 0;

    /// <summary>
    /// The zero-value for an 8-bit signed integer
    /// </summary>
    public const sbyte m8i = sbyte.MaxValue;

    /// <summary>
    /// The zero-value for an 8-bit usigned integer
    /// </summary>
    public const byte m8 = byte.MaxValue;

    /// <summary>
    /// The 0-value for a 16-bit signed integer
    /// </summary>
    public const short m16i = short.MaxValue;

    /// <summary>
    /// The 0-value for a 16-bit unsigned integer
    /// </summary>
    public const ushort m16 = ushort.MaxValue;

    /// <summary>
    /// The zero-value for a 32-bit signed integer
    /// </summary>
    public const int m32i = int.MaxValue;

    /// <summary>
    /// The max-value for a 32-bit usigned integer
    /// </summary>
    public const uint m32 = uint.MaxValue;

    /// <summary>
    /// The max-value for a 64-bit signed integer
    /// </summary>
    public const long m64i = long.MaxValue;

    /// <summary>
    /// The max-value for a 64-bit usigned integer
    /// </summary>
    public const ulong m64 = ulong.MaxValue;

    /// <summary>
    /// The max-value for a 32-bit float
    /// </summary>
    public const float m32f = float.MaxValue;

    /// <summary>
    /// The max-value for a 64-bit float
    /// </summary>
    public const double m64f = double.MaxValue;

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
            return convert<T>(z8i);
        else if(typeof(T) == typeof(short))
            return convert<T>(z16i);
        else if(typeof(T) == typeof(int))
            return convert<T>(z32i);
        else
            return convert<T>(z64i);
    }

    [MethodImpl(Inline)]
    static T minval_u<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return convert<T>(z8);
        else if(typeof(T) == typeof(ushort))
            return convert<T>(z16);
        else if(typeof(T) == typeof(uint))
            return convert<T>(z32);
        else
            return convert<T>(z64);
    }

    [MethodImpl(Inline)]
    static T minval_f<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            return convert<T>(z32f);
        else if(typeof(T) == typeof(double))
            return convert<T>(z64f);
        else
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    static T maxval_i<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return convert<T>(m8i);
        else if(typeof(T) == typeof(short))
            return convert<T>(m16i);
        else if(typeof(T) == typeof(int))
            return convert<T>(m32i);
        else
            return convert<T>(m64i);
    }

    [MethodImpl(Inline)]
    static T maxval_u<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return convert<T>(m8);
        else if(typeof(T) == typeof(ushort))
            return convert<T>(m16);
        else if(typeof(T) == typeof(uint))
            return convert<T>(m32);
        else
            return convert<T>(m64);
    }

    [MethodImpl(Inline)]
    static T maxval_f<T>()
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            return convert<T>(m32f);
        else if(typeof(T) == typeof(double))
            return convert<T>(m64f);
        else
            throw unsupported<T>();
    }

}
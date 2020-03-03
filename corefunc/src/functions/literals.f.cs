//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{       
    /// <summary>
    /// A bit with state 1
    /// </summary>
    public static bit on
    {
        [MethodImpl(Inline)]
        get => bit.On;
    }

    /// <summary>
    /// A bit with state 0
    /// </summary>
    public static bit off
    {
        [MethodImpl(Inline)]
        get => bit.Off;
    }

    /// <summary>
    /// The zero-value for an 8-bit signed integer
    /// </summary>
    public const sbyte z8i = 0;

    /// <summary>
    /// The zero-value for an 8-bit usigned integer
    /// </summary>
    public const byte z8 = 0;

    /// <summary>
    /// The zero-value for a 16-bit signed integer
    /// </summary>
    public const short z16i = 0;

    /// <summary>
    /// The zero-value for a 16-bit unsigned integer
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
    /// The maximum value for an 8-bit signed integer
    /// </summary>
    public const sbyte i8max = sbyte.MaxValue;

    /// <summary>
    /// The maximum value for an 8-bit usigned integer
    /// </summary>
    public const byte u8max = byte.MaxValue;

    /// <summary>
    /// The maximum value for a 16-bit signed integer
    /// </summary>
    public const short i16max = short.MaxValue;

    /// <summary>
    /// The maximum value for a 16-bit unsigned integer
    /// </summary>
    public const ushort u16max = ushort.MaxValue;

    /// <summary>
    /// The maximum value for a 32-bit signed integer
    /// </summary>
    public const int i32max = int.MaxValue;

    /// <summary>
    /// The maximum value for a 32-bit usigned integer
    /// </summary>
    public const uint u32max = uint.MaxValue;

    /// <summary>
    /// The maximum value for a 64-bit signed integer
    /// </summary>
    public const long i64max = long.MaxValue;

    /// <summary>
    /// The maximum value for a 64-bit usigned integer
    /// </summary>
    public const ulong u64max = ulong.MaxValue;

    /// <summary>
    /// The maximum value for a 32-bit float
    /// </summary>
    public const float f32max = float.MaxValue;

    /// <summary>
    /// The maximum value for a 64-bit float
    /// </summary>
    public const double f64max = double.MaxValue;

    /// <summary>
    /// The minimum value for an 8-bit signed integer
    /// </summary>
    public const sbyte i8min = sbyte.MinValue;

    /// <summary>
    /// The minimum value for a 16-bit signed integer
    /// </summary>
    public const short i16min = short.MinValue;

    /// <summary>
    /// The minimum value for a 32-bit signed integer
    /// </summary>
    public const int i32min = int.MinValue;

    /// <summary>
    /// The minimum value for a 64-bit signed integer
    /// </summary>
    public const long i64min = long.MinValue;

    /// <summary>
    /// Returns generic 0 for a primal source type
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T zero<T>(T t = default)
        where T : unmanaged
            => Literals.zero<T>();

    /// <summary>
    /// Returns generic 1 for a primal source type
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T one<T>(T t = default)
        where T : unmanaged
            => Literals.one<T>();

    /// <summary>
    /// Ones all bits each and every ... one
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T ones<T>(T t = default)
        where T : unmanaged
            => Literals.ones<T>();

    /// <summary>
    /// Returns the minimum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T minval<T>()
        where T : unmanaged
            => Literals.minval<T>();

    /// <summary>
    /// Returns the maximum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static T maxval<T>()
        where T : unmanaged
            => Literals.maxval<T>();
}
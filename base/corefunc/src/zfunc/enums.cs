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
    /// Reads a generic value from a generic enum. 
    /// </summary>
    /// <param name="e">The enum value to reinterpret</param>
    /// <typeparam name="E">The enum source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T evalue<E,T>(E e = default, T t = default)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.value(e,t);

    /// <summary>
    /// Reads a generic enum member from a generic value
    /// </summary>
    /// <param name="v">The value to reinterpret</param>
    /// <typeparam name="T">The source value type</typeparam>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe E literal<E,T>(T v, E e = default)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.member(v,e);

    /// <summary>
    /// Gets the literals defined by an enumeration
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static E[] literals<E>(E e = default)
        where E : unmanaged, Enum
            => Enums.members(e);

    /// <summary>
    /// Produces the literals defined by an enumeration together with their integral values
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    public static Pair<E,T>[] lpairs<E,T>(E e = default, T t = default)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.pairs(e,t);

    /// <summary>
    /// Parses an enumeration literal
    /// </summary>
    /// <param name="name">The literal name</param>
    /// <param name="cased">True if casing should be respected, false to ignore case</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static E lparse<E>(string name, bool cased = false, E e = default)
        where E : unmanaged, Enum
            => Enums.parse(name, cased, e);

    // -------------------------

    /// <summary>
    /// Interprets an enum value as a signed byte
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe sbyte esbyte<E>(E e = default, sbyte t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as a byte
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe byte ebyte<E>(E e, byte t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as an unsigned 16-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ushort eushort<E>(E e, ushort t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as a signed 16-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe short eshort<E>(E e, short t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as a signed 32-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe int eint<E>(E e, int t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as an unsigned 32-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe uint euint<E>(E e, uint t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as a signed 64-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe long elong<E>(E e, long t = default)
        where E : unmanaged, Enum
            => evalue(e,t);

    /// <summary>
    /// Interprets an enum value as an unsigned 64-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ulong eulong<E>(E e, ulong t = default)
        where E : unmanaged, Enum
            => evalue(e,t);
}
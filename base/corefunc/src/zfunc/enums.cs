//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
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
    public static unsafe T evalue<E,T>(E e)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.value<E,T>(e);

    /// <summary>
    /// Reads a generic enum member from a generic value
    /// </summary>
    /// <param name="v">The value to reinterpret</param>
    /// <typeparam name="T">The source value type</typeparam>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe E emember<E,T>(T v)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.member<E,T>(v);

    /// <summary>
    /// Gets the literals defined by an enumeration
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static E[] emembers<E>()
        where E : unmanaged, Enum
            => Enums.members<E>();

    /// <summary>
    /// Gets the literals defined by an enumeration together with their integral values
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    public static Pair<E,T>[] epairs<E,T>()
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.pairs<E,T>();

    /// <summary>
    /// Parses an enumeration literal
    /// </summary>
    /// <param name="name">The literal name</param>
    /// <param name="cased">True if casing should be respected, false to ignore case</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static E eparse<E>(string name, bool cased = false)
        where E : unmanaged, Enum
            => Enums.parse<E>(name, cased);

    // -------------------------

    /// <summary>
    /// Interprets an enum value as a signed byte
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe sbyte esbyte<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,sbyte>(e);

    /// <summary>
    /// Interprets an enum value as a byte
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe byte ebyte<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,byte>(e);

    /// <summary>
    /// Interprets an enum value as an unsigned 16-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ushort eushort<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,ushort>(e);

    /// <summary>
    /// Interprets an enum value as a signed 16-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe short eshort<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,short>(e);

    /// <summary>
    /// Interprets an enum value as a signed 32-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe int eint<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,int>(e);

    /// <summary>
    /// Interprets an enum value as an unsigned 32-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe uint euint<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,uint>(e);

    /// <summary>
    /// Interprets an enum value as a signed 64-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe long elong<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,long>(e);

    /// <summary>
    /// Interprets an enum value as an unsigned 64-bit integer
    /// </summary>
    /// <param name="e">The enum value</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ulong eulong<E>(E e)
        where E : unmanaged, Enum
            => evalue<E,ulong>(e);
}
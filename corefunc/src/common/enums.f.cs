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
    /// Reads a generic enum member from a generic value
    /// </summary>
    /// <param name="v">The value to reinterpret</param>
    /// <typeparam name="T">The source value type</typeparam>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe E literal<E,T>(T v, E e = default)
        where E : unmanaged, Enum
        where T : unmanaged
            => Enums.literal(v,e);


}
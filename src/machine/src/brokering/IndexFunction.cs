//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Canonical signature for a function that projects the values of an enumeration onto a congiguous and strictly monotonic sequence
    /// of integers [0,.., n - 1] where n denotes the maximum number of indexed items
    /// </summary>
    /// <param name="kind">The enum literal to map to an integer value</param>
    /// <typeparam name="E">The enum type</typeparam>
    public delegate int IndexFunction<E>(E kind)
        where E : unmanaged, Enum;
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Enums
    {
        public static Index<T> numeric<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => typeof(E).Fields().Select(f => ClrLiterals.value<T>(f));
    }
}
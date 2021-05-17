//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct ClrEnums
    {
        public static Index<T> numeric<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => typeof(E).Fields().Select(f => sys.constant<T>(f));
    }
}
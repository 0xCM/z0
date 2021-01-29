//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Enums
    {
        public static Index<T> numeric<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => ClrLiterals.search<E>(typeof(E)).Select(f => sys.constant<T>(f));
    }
}
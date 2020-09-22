//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct StringTables
    {
        [MethodImpl(Inline), Op]
        public static StringTableCell cell(string data)
            => data;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static StringTableCell<T> cell<T>(in T data)
            => data;
    }
}
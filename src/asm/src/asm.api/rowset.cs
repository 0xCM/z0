//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmRow[] src)
            => new AsmRowSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSets<T> rowsets<T>(AsmRowSet<T>[] src)
            => new AsmRowSets<T>(src);
    }
}
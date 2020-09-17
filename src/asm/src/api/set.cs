//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> set<T>(T key, AsmRow[] src)
            => new AsmRowSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmTableSeg<T> segment<T>(T key, ArraySegment<AsmRow> src)
            => new AsmTableSeg<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSets<T> sets<T>(AsmRowSet<T>[] src)
            => new AsmRowSets<T>(src);
    }
}
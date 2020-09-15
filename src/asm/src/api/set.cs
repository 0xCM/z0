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
        public static AsmRecordSet<T> set<T>(T key, AsmRecord[] src)
            => new AsmRecordSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmTableSeg<T> segment<T>(T key, ArraySegment<AsmRecord> src)
            => new AsmTableSeg<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRecordSets<T> sets<T>(AsmRecordSet<T>[] src)
            => new AsmRecordSets<T>(src);
    }
}
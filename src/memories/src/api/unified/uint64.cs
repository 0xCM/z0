//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong uint64<T>(T src)
            => As.uint64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ulong uint64<T>(ref T src)
            => ref As.uint64(ref src);
     
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As.uint64(src);
    }
}
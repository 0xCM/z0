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
        public static uint uint32<T>(T src)
            => As.uint32(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref uint uint32<T>(ref T src)
            => ref As.uint32(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As.uint32(src);
    }
}
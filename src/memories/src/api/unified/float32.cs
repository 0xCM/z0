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
        public static ref float float32<T>(ref T src)
            => ref As.float32(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static float? float32<T>(T? src)
            where T : unmanaged
                => As.float32(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static float float32<T>(T src)
            => As.float32(src);
    }
}
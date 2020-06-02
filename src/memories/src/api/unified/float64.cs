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
        public static ref double float64<T>(ref T src)
            => ref As.float64(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static double? float64<T>(T? src)
            where T : unmanaged
                => As.float64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static double float64<T>(T src)
            => As.float64(src);
    }
}
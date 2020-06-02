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
        public static byte uint8<T>(T src)
            => As.uint8(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref byte uint8<T>(ref T src)
            => ref As.uint8(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As.uint8(src);
    }
}
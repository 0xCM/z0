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
        public static ushort uint16<T>(T src)
            => As.uint16(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As.uint16(src);
    }
}
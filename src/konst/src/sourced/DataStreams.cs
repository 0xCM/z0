//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct DataStreams
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataSnapshot<T> snapshot<T>(T[] src)
            where T : struct
                => snapshot(src,sys.alloc<int>(1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataSnapshot<T> snapshot<T>(T[] src, int[] index)
            where T : struct
                => new DataSnapshot<T>(src, index);
    }
}

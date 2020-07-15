//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Intervals
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static ref readonly T point<T>(in T src, uint ix)
            where T : unmanaged
                => ref skip(src,ix);        
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static ref readonly T point<T>(in Histogram<T> src, uint ix)
            where T : unmanaged
                => ref src.Partitions[ix];
    }
}
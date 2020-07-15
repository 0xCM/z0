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
        public static ref readonly Bin<T> next<T>(in Bin<T> bin)
            where T : unmanaged
        {
            atomic(ref edit(bin.Counter));
            return ref bin;
        }
    }
}
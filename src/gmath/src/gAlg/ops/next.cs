//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct gAlg
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Bin<T> next<T>(ref Bin<T> bin)
            where T : unmanaged, IComparable<T>
        {
            root.atomic(ref edit(bin.Counter));
            return ref bin;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Seq
    {
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Seq<T> from<T>(IEnumerable<T> src)
            => new Seq<T>(src); 

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Seq<T> from<T>(params T[] src)
            => new Seq<T>(src); 
    }
}
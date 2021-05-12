//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T last<T>(T[] src)
             => ref seek(src, src.Length - 1);
    }
}
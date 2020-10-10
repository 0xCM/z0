//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T regress<T>(in T src, byte offset)
            => ref Add(ref edit(src), -offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T regress<T>(in T src, ushort offset)
            => ref Add(ref edit(src), -offset);
    }
}
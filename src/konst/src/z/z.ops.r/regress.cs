//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T regress<T>(in T src, byte offset)
            => ref memory.sub(src, offset);

        [MethodImpl(Inline)]
        public static ref T regress<T>(in T src, ushort offset)
            => ref memory.sub(src, offset);
    }
}
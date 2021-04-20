//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, byte count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, uint count)
            => ref memory.seek(src, count);


    }
}
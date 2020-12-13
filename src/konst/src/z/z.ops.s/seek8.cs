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
        public static ref byte seek8<T>(in T src, uint count)
            => ref memory.seek8(src,count);

        [MethodImpl(Inline)]
        public static ref byte seek8<T>(Span<T> src, uint count)
             => ref memory.seek8(src,count);
   }
}
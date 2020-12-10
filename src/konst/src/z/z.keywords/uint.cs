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
        public static unsafe uint @uint(bool src)
            => memory.@uint(src);

        [MethodImpl(Inline)]
        public static unsafe uint @uint<T>(T src)
            where T : unmanaged
                => memory.@uint(src);

    }
}
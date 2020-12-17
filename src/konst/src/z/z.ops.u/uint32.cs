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
        public static uint uint32<T>(T src)
            => memory.uint32(src);

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(ref T src)
            => ref memory.uint32(ref src);

        [MethodImpl(Inline)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => memory.uint32(ref src);
    }
}
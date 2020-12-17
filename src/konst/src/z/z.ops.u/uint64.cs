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
        public static ulong uint64<T>(T src)
            => memory.uint64(src);

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(ref T src)
            => ref memory.uint64(ref src);

        [MethodImpl(Inline)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => memory.uint64(src);
    }
}
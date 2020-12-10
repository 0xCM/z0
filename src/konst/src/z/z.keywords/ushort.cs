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
        public static unsafe ushort @ushort(bool src)
            => memory.@ushort(src);

        [MethodImpl(Inline)]
        public static unsafe ushort @ushort<T>(T src)
            where T : unmanaged
                => memory.@ushort(src);
    }
}
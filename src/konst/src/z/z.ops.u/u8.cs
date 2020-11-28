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
        public static ref byte u8(in bit src)
            => ref memory.u8(src);

        [MethodImpl(Inline)]
        public static unsafe byte u8(bool src)
            => memory.u8(src);

        [MethodImpl(Inline)]
        public static ref byte u8<T>(in T src)
            => ref memory.u8(src);

        [MethodImpl(Inline)]
        public static ref byte u8<T>(in T src, int offset)
            => ref memory.u8(src,offset);
    }
}
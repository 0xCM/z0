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
        public static unsafe short i16(bool src)
            => memory.i16(src);

        [MethodImpl(Inline)]
        public static ref short i16<T>(in T src)
            => ref memory.i16(src);
    }
}
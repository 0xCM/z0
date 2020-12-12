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
        public static unsafe sbyte i8(bool src)
            => memory.i8(src);

        [MethodImpl(Inline)]
        public static ref sbyte i8<T>(in T src)
            => ref memory.i8(src);
    }
}
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
        public static unsafe long @long(bool src)
            => memory.@long(src);

        [MethodImpl(Inline)]
        public static unsafe long @long<T>(T src)
            where T : unmanaged
                => memory.@long(src);
    }
}
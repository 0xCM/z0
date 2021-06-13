//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static Span<T> clear<T>(Span<T> src)
            => sys.clear(src);

        [MethodImpl(Inline)]
        public static T[] clear<T>(T[] dst)
            => sys.clear(dst);
    }
}
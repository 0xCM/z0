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
        public static T[] alloc<T>(uint count)
            => memory.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(long count)
            => memory.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(ulong count)
            => memory.alloc<T>(count);
    }
}
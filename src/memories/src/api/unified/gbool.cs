//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static T generic<T>(bool src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static bool boolean<T>(T src)
            => As.boolean(src);

    }
}
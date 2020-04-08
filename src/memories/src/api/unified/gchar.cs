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
        public static T generic<T>(char src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static char character<T>(T src)        
            => As.character(src);
    }
}
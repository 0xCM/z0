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
        public static int @int(bool src)
            => memory.@int(src);

        [MethodImpl(Inline)]
        public static int @int(float src)
            => memory.@int(src);

        [MethodImpl(Inline)]
        public static int @int<T>(T src)
            where T : unmanaged
                => memory.@int(src);
    }
}
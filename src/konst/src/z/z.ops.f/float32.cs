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
        public static float float32<T>(T src)
            => memory.float32(src);

        [MethodImpl(Inline)]
        public static ref float float32<T>(ref T src)
            => ref memory.float32(ref src);

        [MethodImpl(Inline)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => memory.float32(src);
    }
}
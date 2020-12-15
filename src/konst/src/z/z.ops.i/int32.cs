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
        public static int int32<T>(T src)
            => memory.int32(src);

        [MethodImpl(Inline)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => memory.int32(src);

        [MethodImpl(Inline)]
        public static ref int int32<T>(ref T src)
            => ref memory.int32(ref src);
    }
}
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
        public static long int64<T>(T src)
            => memory.int64(src);

        [MethodImpl(Inline)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => memory.int64(src);

        [MethodImpl(Inline)]
        public static ref long int64<T>(ref T src)
            => ref memory.int64(ref src);
    }
}
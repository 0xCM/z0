//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref float float32<T>(ref T src)
            => ref As.float32(ref src);

        [MethodImpl(Inline)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => As.float32(src);

        [MethodImpl(Inline)]
        public static float float32<T>(T src)
            => As.float32(src);
    }
}
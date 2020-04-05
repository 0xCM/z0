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
        public static T generic<T>(long src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static long int64<T>(T src)
            => As.int64(src);

        [MethodImpl(Inline)]
        public static ref long int64<T>(ref T src)
            => ref As.int64(ref src);

        [MethodImpl(Inline)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => As.int64(src);
    }
}
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
        public static T generic<T>(int src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref int src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static int int32<T>(T src)
            => As.int32(src);

        [MethodImpl(Inline)]
        public static ref int int32<T>(ref T src)
            => ref As.int32(ref src);

        [MethodImpl(Inline)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => As.int32(src);
    }
}
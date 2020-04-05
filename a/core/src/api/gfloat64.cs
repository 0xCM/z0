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
        public static T generic<T>(double src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref As.float64(ref src);

        [MethodImpl(Inline)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => As.float64(src);

        [MethodImpl(Inline)]
        public static double float64<T>(T src)
            => As.float64(src);
    }
}
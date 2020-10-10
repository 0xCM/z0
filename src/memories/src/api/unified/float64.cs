//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref AsDeprecated.float64(ref src);

        [MethodImpl(Inline)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => AsDeprecated.float64(src);
    }
}
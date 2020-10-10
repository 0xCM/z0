//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    partial struct AsDeprecated
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long int64<T>(T src)
            => As<T,long>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref long int64<T>(ref T src)
            => ref As<T,long>(ref src);
    }
}
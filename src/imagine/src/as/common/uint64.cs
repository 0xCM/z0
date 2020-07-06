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

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong uint64<T>(ref T src)
            => ref As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As<T?,ulong?>(ref src);
    }
}
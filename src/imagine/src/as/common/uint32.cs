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
        public static ref uint uint32<T>(ref T src)
            => ref As<T,uint>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As<T?,uint?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<uint> uint32<T>(Span<T> src)
            where T : struct
                => cast<T,uint>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> uint32<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,uint>(src);
    }
}
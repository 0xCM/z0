//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static z;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> gt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> gt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in Block128<T> a, Span<bit> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> nonz<T>(in Block256<T> a, Span<bit> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> testc<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testc<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> testc<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testc<T>(w256).Invoke(a, b, dst);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static Memories;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> add<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.add<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> add<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.add<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> sub<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.sub<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> sub<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.sub<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block128<T> abs<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block256<T> abs<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> dec<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.dec<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> dec<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.dec<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> inc<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.inc<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> inc<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.inc<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> negate<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.negate<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> negate<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.negate<T>(w256).Invoke(a, dst);
    }
}
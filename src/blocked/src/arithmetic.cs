//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed; 
    using static Memories;
    using static SBlock;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> add<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a, b, c, VSvc.vadd<T>(w128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> add<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a, b, c, VSvc.vadd<T>(w256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> sub<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a, b, c, VSvc.vsub<T>(w128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> sub<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a, b, c, VSvc.vsub<T>(w256));

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block128<T> abs<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref map(a,c, VSvc.vabs<T>(w128));

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block256<T> abs<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vabs<T>(w256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> dec<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vdec<T>(w128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> dec<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vdec<T>(w256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> inc<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vinc<T>(w128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> inc<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vinc<T>(w256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> negate<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vnegate<T>(w128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> negate<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref map(a, c, VSvc.vnegate<T>(w256));
    }
}
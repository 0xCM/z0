//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static memory;
    using static SFx;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx128<T> vrotlx<T>(W128 w)
            where T : unmanaged
                => default(VRotlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx256<T> vrotlx<T>(W256 w)
            where T : unmanaged
                => default(VRotlx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotl128<T> vrotl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VRotl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotl256<T> vrotl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VRotl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> rotl<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref rotl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> rotl<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref rotl<T>(w256).Invoke(a, count, dst);
    }
}
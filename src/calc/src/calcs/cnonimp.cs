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
        [MethodImpl(Inline), Factory(CNonImpl), Closures(Integers)]
        public static CNonImpl<T> cnonimpl<T>()
            where T : unmanaged
                => default(CNonImpl<T>);

        [MethodImpl(Inline), Factory(CNonImpl), Closures(Integers)]
        public static CNonImpl128<T> cnonimpl<T>(W128 w)
            where T : unmanaged
                => default(CNonImpl128<T>);

        [MethodImpl(Inline), Factory(CNonImpl), Closures(Integers)]
        public static CNonImpl256<T> cnonimpl<T>(W256 w)
            where T : unmanaged
                => default(CNonImpl256<T>);

        [MethodImpl(Inline), CNonImpl, Closures(Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(cnonimpl<T>(), a, b, dst);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static ref readonly SpanBlock128<T> cnonimpl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref cnonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static ref readonly SpanBlock256<T> cnonimpl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref cnonimpl<T>(w256).Invoke(a, b, dst);
    }
}
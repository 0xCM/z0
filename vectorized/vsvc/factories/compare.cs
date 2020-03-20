//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static VSvcHosts;

    partial class VSvcFactories
    {
        [MethodImpl(Inline)]
        public static Eq128<T> veq<T>(N128 w, T t = default)
            where T : unmanaged
                => Eq128<T>.Op;

        [MethodImpl(Inline)]
        public static Eq256<T> veq<T>(N256 w, T t = default)
            where T : unmanaged
                => Eq256<T>.Op;

        [MethodImpl(Inline)]
        public static Lt128<T> vlt<T>(N128 w, T t = default)
            where T : unmanaged
                => Lt128<T>.Op;

        [MethodImpl(Inline)]
        public static Lt256<T> vlt<T>(N256 w, T t = default)
            where T : unmanaged
                => Lt256<T>.Op;

        [MethodImpl(Inline)]
        public static Gt128<T> vgt<T>(N128 w, T t = default)
            where T : unmanaged
                => Gt128<T>.Op;

        [MethodImpl(Inline)]
        public static Gt256<T> vgt<T>(N256 w, T t = default)
            where T : unmanaged
                => Gt256<T>.Op;
 
        [MethodImpl(Inline)]
        public static Max128<T> vmax<T>(N128 w, T t = default)
            where T : unmanaged
                => Max128<T>.Op;

        [MethodImpl(Inline)]
        public static Max256<T> vmax<T>(N256 w, T t = default)
            where T : unmanaged
                => Max256<T>.Op;

        [MethodImpl(Inline)]
        public static Min128<T> vmin<T>(N128 w, T t = default)
            where T : unmanaged
                => Min128<T>.Op;

        [MethodImpl(Inline)]
        public static Min256<T> vmin<T>(N256 w, T t = default)
            where T : unmanaged
                => Min256<T>.Op;

        [MethodImpl(Inline)]
        public static NonZ128<T> vnonz<T>(N128 w, T t = default)
            where T : unmanaged
                => NonZ128<T>.Op;

        [MethodImpl(Inline)]
        public static NonZ256<T> vnonz<T>(N256 w, T t = default)
            where T : unmanaged
                => NonZ256<T>.Op;

        [MethodImpl(Inline)]
        public static TestC128<T> vtestc<T>(N128 w, T t = default)
            where T : unmanaged
                => TestC128<T>.Op;

        [MethodImpl(Inline)]
        public static TestC256<T> vtestc<T>(N256 w, T t = default)
            where T : unmanaged
                => TestC256<T>.Op;

        [MethodImpl(Inline)]
        public static TestZ128<T> vtestz<T>(N128 w, T t = default)
            where T : unmanaged
                => TestZ128<T>.Op;

        [MethodImpl(Inline)]
        public static TestZ256<T> vtestz<T>(N256 w, T t = default)
            where T : unmanaged
                => TestZ256<T>.Op;
    }
}
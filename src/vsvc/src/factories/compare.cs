//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Eq128<T> veq<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Eq128<T>);

        [MethodImpl(Inline)]
        public static Eq256<T> veq<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Eq256<T>);

        [MethodImpl(Inline)]
        public static Lt128<T> vlt<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Lt128<T>);

        [MethodImpl(Inline)]
        public static Lt256<T> vlt<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Lt256<T>);

        [MethodImpl(Inline)]
        public static Gt128<T> vgt<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Gt128<T>);

        [MethodImpl(Inline)]
        public static Gt256<T> vgt<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Gt256<T>);
 
        [MethodImpl(Inline)]
        public static Max128<T> vmax<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Max128<T>);

        [MethodImpl(Inline)]
        public static Max256<T> vmax<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Max256<T>);

        [MethodImpl(Inline)]
        public static Min128<T> vmin<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Min128<T>);

        [MethodImpl(Inline)]
        public static Min256<T> vmin<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Min256<T>);

        [MethodImpl(Inline)]
        public static NonZ128<T> vnonz<T>(W128 w, T t = default)
            where T : unmanaged
                => default(NonZ128<T>);

        [MethodImpl(Inline)]
        public static NonZ256<T> vnonz<T>(W256 w, T t = default)
            where T : unmanaged
                => default(NonZ256<T>);

        [MethodImpl(Inline)]
        public static TestC128<T> vtestc<T>(W128 w, T t = default)
            where T : unmanaged
                => default(TestC128<T>);

        [MethodImpl(Inline)]
        public static TestC256<T> vtestc<T>(W256 w, T t = default)
            where T : unmanaged
                => default(TestC256<T>);

        [MethodImpl(Inline)]
        public static TestZ128<T> vtestz<T>(W128 w, T t = default)
            where T : unmanaged
                => default(TestZ128<T>);

        [MethodImpl(Inline)]
        public static TestZ256<T> vtestz<T>(W256 w, T t = default)
            where T : unmanaged
                => default(TestZ256<T>);
    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BSvcHosts;

    partial class BSvc 
    {
        [MethodImpl(Inline)]
        public static Eq128<T> eq<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Eq128<T>);

        [MethodImpl(Inline)]
        public static Eq256<T> eq<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Eq256<T>);

        [MethodImpl(Inline)]
        public static Lt128<T> lt<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Lt128<T>);

        [MethodImpl(Inline)]
        public static Lt256<T> lt<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Lt256<T>);

        [MethodImpl(Inline)]
        public static Gt128<T> gt<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Gt128<T>);

        [MethodImpl(Inline)]
        public static Gt256<T> gt<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Gt256<T>);
 
        [MethodImpl(Inline)]
        public static Max128<T> max<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Max128<T>);

        [MethodImpl(Inline)]
        public static Max256<T> max<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Max256<T>);

        [MethodImpl(Inline)]
        public static Min128<T> min<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Min128<T>);

        [MethodImpl(Inline)]
        public static Min256<T> min<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Min256<T>);

        [MethodImpl(Inline)]
        public static NonZ128<T> nonz<T>(W128 w, T t = default)
            where T : unmanaged
                => default(NonZ128<T>);

        [MethodImpl(Inline)]
        public static NonZ256<T> nonz<T>(W256 w, T t = default)
            where T : unmanaged
                => default(NonZ256<T>);

        [MethodImpl(Inline)]
        public static TestC128<T> testc<T>(W128 w, T t = default)
            where T : unmanaged
                => default(TestC128<T>);

        [MethodImpl(Inline)]
        public static TestC256<T> testc<T>(W256 w, T t = default)
            where T : unmanaged
                => default(TestC256<T>);

        [MethodImpl(Inline)]
        public static TestZ128<T> testz<T>(W128 w, T t = default)
            where T : unmanaged
                => default(TestZ128<T>);

        [MethodImpl(Inline)]
        public static TestZ256<T> testz<T>(W256 w, T t = default)
            where T : unmanaged
                => default(TestZ256<T>);
    }
}
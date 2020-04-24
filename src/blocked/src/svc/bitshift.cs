
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
        public static Sll128<T> sll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sll128<T>);

        [MethodImpl(Inline)]
        public static Sll256<T> sll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sll256<T>);

        [MethodImpl(Inline)]
        public static Srl128<T> srl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Srl128<T>);

        [MethodImpl(Inline)]
        public static Srl256<T> srl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Srl256<T>);

        [MethodImpl(Inline)]
        public static Bsrl128<T> bsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Bsrl128<T>);

        [MethodImpl(Inline)]
        public static Bsrl256<T> bsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Bsrl256<T>);

        [MethodImpl(Inline)]
        public static Bsll128<T> bsll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Bsll128<T>);

        [MethodImpl(Inline)]
        public static Bsll256<T> bsll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Bsll256<T>);

        [MethodImpl(Inline)]
        public static Rotr128<T> rotr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotr128<T>);

        [MethodImpl(Inline)]
        public static Rotr256<T> rotr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotr256<T>);

        [MethodImpl(Inline)]
        public static Rotl128<T> rotl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotl128<T>);

        [MethodImpl(Inline)]
        public static Rotl256<T> rotl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotl256<T>);

        [MethodImpl(Inline)]
        public static Xors128<T> xors<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Xors128<T>);

        [MethodImpl(Inline)]
        public static Xors256<T> xors<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Xors256<T>);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Rotrx128<T> vrotrx<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotrx128<T>.Op;

        [MethodImpl(Inline)]
        public static Rotrx256<T> vrotrx<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotrx256<T>.Op;

        [MethodImpl(Inline)]
        public static Rotlx128<T> vrotlx<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotlx128<T>.Op;

        [MethodImpl(Inline)]
        public static Rotlx256<T> vrotlx<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotlx256<T>.Op;

        [MethodImpl(Inline)]
        public static Rotl128<T> vrotl<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotl128<T>.Op;

        [MethodImpl(Inline)]
        public static Rotl256<T> vrotl<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotl256<T>.Op;

        [MethodImpl(Inline)]
        public static Rotr128<T> vrotr<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotr128<T>.Op;

        [MethodImpl(Inline)]
        public static Rotr256<T> vrotr<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotr256<T>.Op; 
    }
}
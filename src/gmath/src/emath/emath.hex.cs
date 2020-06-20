//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static Konst;


    [ApiHost("emath")]
    readonly struct EClosures
    {
        [MethodImpl(Inline), Add, Closures(Numeric8u)]
        public static @enum<E8u,T> add<T>(@enum<E8u,T> a, @enum<E8u,T> b)
            where T : unmanaged
                => emath.add(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric8u)]
        public static @enum<E8u,T> mul<T>(@enum<E8u,T> a, @enum<E8u,T> b)
            where T : unmanaged
                => emath.mul(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric8u)]
        public static @enum<E8u,T> and<T>(@enum<E8u,T> a, @enum<E8u,T> b)
            where T : unmanaged
                => emath.and(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric8i)]
        public static @enum<E8i,T> add<T>(@enum<E8i,T> a, @enum<E8i,T> b)
            where T : unmanaged
                => emath.add(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric8i)]
        public static @enum<E8i,T> mul<T>(@enum<E8i,T> a, @enum<E8i,T> b)
            where T : unmanaged
                => emath.mul(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric8i)]
        public static @enum<E8i,T> and<T>(@enum<E8i,T> a, @enum<E8i,T> b)
            where T : unmanaged
                => emath.and(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric32u)]
        public static @enum<E32u,T> add<T>(@enum<E32u,T> a, @enum<E32u,T> b)
            where T : unmanaged
                => emath.add(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric32u)]
        public static @enum<E32u,T> mul<T>(@enum<E32u,T> a, @enum<E32u,T> b)
            where T : unmanaged
                => emath.mul(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric32u)]
        public static @enum<E32u,T> and<T>(@enum<E32u,T> a, @enum<E32u,T> b)
            where T : unmanaged
                => emath.and(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric64u)]
        public static @enum<E64u,T> add<T>(@enum<E64u,T> a, @enum<E64u,T> b)
            where T : unmanaged
                => emath.add(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric64u)]
        public static @enum<E64u,T> mul<T>(@enum<E64u,T> a, @enum<E64u,T> b)
            where T : unmanaged
                => emath.mul(a, b);

        [MethodImpl(Inline), Add, Closures(Numeric64u)]
        public static @enum<E64u,T> and<T>(@enum<E64u,T> a, @enum<E64u,T> b)
            where T : unmanaged
                => emath.and(a, b);

    }


    enum E8u : byte
    {

    }

    enum E8i : sbyte
    {

    }

    enum E16i : short
    {

    }

    enum E16u : ushort
    {

    }

    enum E32i : int
    {

    }

    enum E32u : uint
    {

    }

    enum E64i : long
    {

    }

    enum E64u : ulong
    {

    }

}
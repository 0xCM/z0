//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct nfunc
    {
        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte nat8i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (sbyte)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static byte nat8u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (byte)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static short nat16i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (short)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static ushort nat16u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (ushort)TypeNats.value(n);
        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static int nat32i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (int)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static uint nat32u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (uint)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static ulong nat64u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representative</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static long nat64i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (long)TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n"></param>
        /// <param name="t"></param>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T nat<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  memory.@as<ulong,T>(TypeNats.value(n));

        /// <summary>
        /// Constructs a natural representative
        /// </summary>
        /// <typeparam name="K">The representative type</typeparam>
        [MethodImpl(Inline)]
        public static K natrep<K>()
            where K : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Demands truth that is enforced with an exception upon false
        /// </summary>
        /// <param name="x">The value to test</param>
        internal static bool demand(bool x, string message = null)
            => x ? x : throw new Exception(message ?? "demand failed");
    }

}
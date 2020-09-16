//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Sized
    {
        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint1 scalar<K>(in K src, N1 n)
            where K : unmanaged, Enum
                =>ref @as<K,uint1>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint2 scalar<K>(in K src, N2 n)
            where K : unmanaged, Enum
                => ref @as<K,uint2>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint3 scalar<K>(in K src, N3 n)
            where K : unmanaged, Enum
                => ref @as<K,uint3>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint4 scalar<K>(in K src, N4 n)
            where K : unmanaged, Enum
                => ref @as<K,uint4>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint5 scalar<K>(in K src, N5 n)
            where K : unmanaged, Enum
                =>ref @as<K,uint5>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint6 scalar<K>(in K src, N6 n)
            where K : unmanaged, Enum
                => ref @as<K,uint6>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint7 scalar<K>(in K src, N7 n)
            where K : unmanaged, Enum
                => ref @as<K,uint7>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref octet scalar<K>(in K src, N8 n)
            where K : unmanaged, Enum
                => ref @as<K,octet>(src);
    }
}
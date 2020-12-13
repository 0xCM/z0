//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Pow2;

    partial struct BitReader
    {
        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N0 n, ulong src)
            => (ulong)(T00 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N1 n, ulong src)
            => (ulong)(T01 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N2 n, ulong src)
            => (ulong)(T02 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N3 n, ulong src)
            => (ulong)(T03 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N4 n, ulong src)
            => (ulong)(T04 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N5 n, ulong src)
            => (ulong)(T05 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N6 n, ulong src)
            => (ulong)(T06 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N7 n, ulong src)
            => (ulong)(T07 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N8 n, ulong src)
            => (ulong)(T08 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N9 n, ulong src)
            => (ulong)(T09 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N10 n, ulong src)
            => (ulong)(T10 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N11 n, ulong src)
            => (ulong)(T11 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N12 n, ulong src)
            => (ulong)(T12 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N13 n, ulong src)
            => (ulong)(T13 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N14 n, ulong src)
            => (ulong)(T14 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong bit(N15 n, ulong src)
            => (ulong)(T15 & src);
    }
}
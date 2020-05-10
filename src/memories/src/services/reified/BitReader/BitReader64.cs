//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BitSelectors;

    partial struct BitReader
    {
        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N0 n, ulong src)
            => (ulong)(Bit0 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N1 n, ulong src)
            => (ulong)(Bit1 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N2 n, ulong src)
            => (ulong)(Bit2 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N3 n, ulong src)
            => (ulong)(Bit3 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N4 n, ulong src)
            => (ulong)(Bit4 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N5 n, ulong src)
            => (ulong)(Bit5 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N6 n, ulong src)
            => (ulong)(Bit6 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N7 n, ulong src)
            => (ulong)(Bit7 & src);                

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N8 n, ulong src)
            => (ulong)(Bit8 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N9 n, ulong src)
            => (ulong)(Bit9 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N10 n, ulong src)
            => (ulong)(Bit10 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N11 n, ulong src)
            => (ulong)(Bit11 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N12 n, ulong src)
            => (ulong)(Bit12 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N13 n, ulong src)
            => (ulong)(Bit13 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N14 n, ulong src)
            => (ulong)(Bit14 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(N15 n, ulong src)
            => (ulong)(Bit15 & src);                            
    }
}
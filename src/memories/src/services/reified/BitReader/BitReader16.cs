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
        public static ushort Read(N0 n, ushort src)
            => (ushort)(Bit0 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N1 n, ushort src)
            => (ushort)(Bit1 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N2 n, ushort src)
            => (ushort)(Bit2 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N3 n, ushort src)
            => (ushort)(Bit3 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N4 n, ushort src)
            => (ushort)(Bit4 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N5 n, ushort src)
            => (ushort)(Bit5 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N6 n, ushort src)
            => (ushort)(Bit6 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N7 n, ushort src)
            => (ushort)(Bit7 & src);                

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N8 n, ushort src)
            => (ushort)(Bit8 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N9 n, ushort src)
            => (ushort)(Bit9 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N10 n, ushort src)
            => (ushort)(Bit10 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N11 n, ushort src)
            => (ushort)(Bit11 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N12 n, ushort src)
            => (ushort)(Bit12 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N13 n, ushort src)
            => (ushort)(Bit13 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N14 n, ushort src)
            => (ushort)(Bit14 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static ushort Read(N15 n, ushort src)
            => (ushort)(Bit15 & src);                            
    }
}
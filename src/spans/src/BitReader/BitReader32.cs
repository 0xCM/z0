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
        public static uint Read(N0 n, uint src)
            => (uint)(Bit0 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N1 n, uint src)
            => (uint)(Bit1 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N2 n, uint src)
            => (uint)(Bit2 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N3 n, uint src)
            => (uint)(Bit3 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N4 n, uint src)
            => (uint)(Bit4 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N5 n, uint src)
            => (uint)(Bit5 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N6 n, uint src)
            => (uint)(Bit6 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N7 n, uint src)
            => (uint)(Bit7 & src);                

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N8 n, uint src)
            => (uint)(Bit8 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N9 n, uint src)
            => (uint)(Bit9 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N10 n, uint src)
            => (uint)(Bit10 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N11 n, uint src)
            => (uint)(Bit11 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N12 n, uint src)
            => (uint)(Bit12 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N13 n, uint src)
            => (uint)(Bit13 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N14 n, uint src)
            => (uint)(Bit14 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static uint Read(N15 n, uint src)
            => (uint)(Bit15 & src);                            
    }
}
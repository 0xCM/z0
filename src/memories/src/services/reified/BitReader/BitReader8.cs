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
        public static byte Read(N0 n, byte src)
            => (byte)(Bit0 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N1 n, byte src)
            => (byte)(Bit1 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N2 n, byte src)
            => (byte)(Bit2 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N3 n, byte src)
            => (byte)(Bit3 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N4 n, byte src)
            => (byte)(Bit4 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N5 n, byte src)
            => (byte)(Bit5 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N6 n, byte src)
            => (byte)(Bit6 & src);

        /// <summary>
        /// Reads the state of a naturally-identified bit
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bit selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(N7 n, byte src)
            => (byte)(Bit7 & src);                
    }
}
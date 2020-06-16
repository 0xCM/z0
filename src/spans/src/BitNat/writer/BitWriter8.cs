//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BitReader;

    partial struct BitWriter
    {
        [MethodImpl(Inline)]
        static byte write(byte src, int pos, byte state)            
        {
            var c = ~state + 1;
            src ^= (byte)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N0 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N1 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N2 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N3 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N4 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N5 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N6 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static byte write(N7 n, byte src, byte dst)
            =>  write(dst, n, bit(n, src));            
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BitReader;

    partial struct BitWriter
    {
        [MethodImpl(Inline)]
        static uint write(uint src, int pos, uint state)                    
        {
            var c = ~(uint)state + 1u;
            src ^= (c ^ src) & (1u << pos);
            return src;
        }

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint write(N0 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint write(N1 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint Write(N2 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint write(N3 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint write(N4 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint write(N5 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint Write(N6 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));

        /// <summary>
        /// Transfers the state of a naturally-identified source bit to the corresponding bit in the target
        /// </summary>
        /// <param name="n">The bit selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static uint Write(N7 n, uint src, uint dst)
            =>  write(dst, n, bit(n, src));            
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
   
    partial class Bits
    {               
        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(byte src)
            => As.testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(sbyte src)
            => As.testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(ushort src)
            => As.testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(short src)
            => As.testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(uint src)
            => As.testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(int src)
            => As.testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(ulong src)
            => As.testbit(src,63);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Bit msb(long src)
            => As.testbit(src,63);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
   
    partial class Bits
    {               
        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(byte src)
            => (OneBit)(byte)testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(sbyte src)
            => (OneBit)(byte)testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(ushort src)
            => (OneBit)(byte)testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(short src)
            => (OneBit)(byte)testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(uint src)
            => (OneBit)(byte)testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(int src)
            => (OneBit)(byte)testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(ulong src)
            => (OneBit)(byte)testbit(src,63);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static OneBit msb(long src)
            => (OneBit)(byte)testbit(src,63);
    }
}
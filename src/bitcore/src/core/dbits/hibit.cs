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
        public static BitKind msb(byte src)
            => (BitKind)(byte)testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(sbyte src)
            => (BitKind)(byte)testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(ushort src)
            => (BitKind)(byte)testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(short src)
            => (BitKind)(byte)testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(uint src)
            => (BitKind)(byte)testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(int src)
            => (BitKind)(byte)testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(ulong src)
            => (BitKind)(byte)testbit(src,63);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitKind msb(long src)
            => (BitKind)(byte)testbit(src,63);
    }
}
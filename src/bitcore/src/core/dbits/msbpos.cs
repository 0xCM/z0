//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    partial class Bits
    {                 
        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 7
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static int msbpos(byte src)            
            => bitsize<byte>() - 1 - nlz(src);

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 15
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static int msbpos(ushort src)            
            => bitsize<ushort>() - 1 - nlz(src);

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 31
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static int msbpos(uint src)            
            => bitsize<uint>() - 1 - nlz(src) ;

        /// <summary>
        /// Computes the position of the highest enabled source bit, a number between 0 and 63
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static int msbpos(ulong src)            
            => bitsize<ulong>() - 1 - nlz(src);
    }
}
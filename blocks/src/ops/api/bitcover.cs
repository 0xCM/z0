//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Seed;        

    partial class Blocks
    {
        /// <summary>
        /// Computes the number of blocks required to cover a specified number of bits
        /// </summary>
        /// <param name="srcbits">The source bit count</param>
        /// <param name="blockwidth">The block width in bits</param>
        [MethodImpl(Inline)]
        public static int bitcover(int srcbits, int blockwidth)
        {
            var a = srcbits / blockwidth;
            return a + (srcbits % a == 0 ? 0 : 1);
        }

        /// <summary>
        /// Computes the number of blocks required to cover a specified number of bits
        /// </summary>
        /// <param name="dstblockbits">The target block size in bits</param>
        [MethodImpl(Inline)]
        public static int bitcover<T>(int srcbits)
            where T : unmanaged
                => bitcover(srcbits, Unsafe.SizeOf<T>()*8);
    }
}
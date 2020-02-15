//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;    
    using static HexConst;
 
    public static partial class Data
    {
        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x16u
            => new byte[16]{1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E};

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x32u
            => new byte[16]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x64u
            => new byte[16]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x16u
            => new byte[32]{
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E,
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x32u
            => new byte[32]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C,
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };


        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x64u
            => new byte[32]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8,
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                };                        
    }
}
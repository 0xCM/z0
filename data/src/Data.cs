//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static HexConst;
 
    public static partial class Data
    {
        public static ReadOnlySpan<byte> Inc128x8  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,B,12,13,14,F};

        public static ReadOnlySpan<byte> Inc128x16  
            => new byte[16]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0};

        public static ReadOnlySpan<byte> Inc128x32  
            => new byte[16]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0};

        public static ReadOnlySpan<byte> Inc128x64  
            => new byte[16]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Inc256x8  
            => new byte[32]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
                };
        public static ReadOnlySpan<byte> Inc256x16  
            => new byte[32]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0
                };

        public static ReadOnlySpan<byte> Inc256x32  
            => new byte[32]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0
                };

        public static ReadOnlySpan<byte> Inc256x64  
            => new byte[32]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Inc512x8  
            => new byte[64]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,
                32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,
                48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63
                };

        public static ReadOnlySpan<byte> Inc512x16  
            => new byte[64]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0,
                16,0,17,0,18,0,19,0,20,0,21,0,22,0,23,0,
                24,0,25,0,26,0,27,0,28,0,29,0,30,0,31,0
                };

        public static ReadOnlySpan<byte> Inc512x32  
            => new byte[64]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0,
                8,0,0,0,9,0,0,0,A,0,0,0,B,0,0,0,
                C,0,0,0,D,0,0,0,E,0,0,0,F,0,0,0
                };

        public static ReadOnlySpan<byte> Inc512x64  
            => new byte[64]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,
                4,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,
                6,0,0,0,0,0,0,0,7,0,0,0,0,0,0,0,
                };

        public static ReadOnlySpan<byte> Dec128x8u 
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        public static ReadOnlySpan<byte> Dec128x16u  
            => new byte[16]{7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0};

        public static ReadOnlySpan<byte> Dec128x32u  
            => new byte[16]{3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Dec128x64u  
            => new byte[16]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Dec256x8u  
            => new byte[32]{
                31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,
                15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0
                };

        public static ReadOnlySpan<byte> Dec256x16u  
            => new byte[32]{
                15,0,14,0,13,0,12,0,11,0,10,0,9,0,8,0,
                7,0,6,0,5,0,4,0,3,0,2,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Dec256x32u  
            => new byte[32]{
                7,0,0,0,6,0,0,0,5,0,0,0,4,0,0,0,
                3,0,0,0,2,0,0,0,1,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Dec256x64u  
            => new byte[32]{
                3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Units128x8u
            => new byte[16]{
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
                };

        public static ReadOnlySpan<byte> Units128x16u
            => new byte[16]{
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
                };

        public static ReadOnlySpan<byte> Units128x32u
            => new byte[16]{
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Units128x64u
            => new byte[16]{
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Units256x8u
            => new byte[32]{
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
                };

        public static ReadOnlySpan<byte> Units256x16u
            => new byte[32]{
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
                };

        public static ReadOnlySpan<byte> Units256x32u
            => new byte[32]{
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Units256x64u
            => new byte[32]{
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
                }; 

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap128x16u
            => new byte[16]{1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E};

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap128x32u
            => new byte[16]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap128x64u
            => new byte[16]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap256x16u
            => new byte[32]{
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E,
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap256x32u
            => new byte[32]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C,
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };


        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        public static ReadOnlySpan<byte> ByteSwap256x64u
            => new byte[32]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8,
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                };

        public static ReadOnlySpan<byte> PackUS16Lo128x8
            => new byte[16]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUS16Hi128x8
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUS32Lo128x16
            => new byte[16]{
                0,1, 4,5, 8,9, 12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUS32Hi128x16
            => new byte[16]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0,1,4,5,8,9,12,13
                };

        public static ReadOnlySpan<byte> PackUS16Lo256x8
            => new byte[32]{
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF
                };

        public static ReadOnlySpan<byte> PackUS16Hi256x8
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                FF,FF,FF,FF,FF,FF,FF,FF, 
                0, 2, 4, 6, 8, 10,12,14, 
                };

        public static ReadOnlySpan<byte> PackUS32Lo256x16
            => new byte[32]{
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13, 
                FF,FF,FF,FF,FF,FF,FF,FF,
                };

        public static ReadOnlySpan<byte> PackUS32Hi256x16
            => new byte[32]{
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13,
                FF,FF,FF,FF,FF,FF,FF,FF,
                0,1,4,5,8,9,12,13
                };                
    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static HexConst;

    public readonly struct VectorData
    {        
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

        public static ReadOnlySpan<byte> Inc128x8u  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,B,12,13,14,F};

        public static ReadOnlySpan<byte> Inc128x16u  
            => new byte[16]{0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0};

        public static ReadOnlySpan<byte> Inc128x32u  
            => new byte[16]{0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0};

        public static ReadOnlySpan<byte> Inc128x64u  
            => new byte[16]{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Inc256x8u  
            => new byte[32]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31
                };

        public static ReadOnlySpan<byte> Inc256x16u  
            => new byte[32]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0
                };

        public static ReadOnlySpan<byte> Inc256x32u  
            => new byte[32]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0
                };

        public static ReadOnlySpan<byte> Inc256x64u  
            => new byte[32]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0
                };
    }
}
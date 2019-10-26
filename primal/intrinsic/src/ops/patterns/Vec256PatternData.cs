//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static VecParts256x8u;


    public static class Vec256PatternData
    {
        const int n = 32;

        public static ReadOnlySpan<byte> Inc8u  
            => new byte[n]{
                LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,
                HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,
            };

        public static ReadOnlySpan<byte> Inc16u  
            => new byte[n]{
                LA,0,LB,0,LC,0,LD,0,LE,0,LF,0,LG,0,LH,0,
                HA,0,HB,0,HD,0,HD,0,HE,0,HF,0,HG,0,HH,0,
            };

        public static ReadOnlySpan<byte> Inc32u  
            => new byte[n]{
                LA,0,0,0,LB,0,0,0,LC,0,0,0,LD,0,0,0,
                HE,0,0,0,HF,0,0,0,HG,0,0,0,HH,0,0,0,
            };

        public static ReadOnlySpan<byte> Inc64u  
            => new byte[n]{
                LA,0,0,0,0,0,0,0,LB,0,0,0,0,0,0,0,
                HC,0,0,0,0,0,0,0,HD,0,0,0,0,0,0,0,
            };

        public static ReadOnlySpan<byte> LaneMerge256x8u 
            => new byte[n]{0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31};
        
        public static ReadOnlySpan<byte> LaneMerge256x16u 
            => new byte[n]{0x00,0x00,0x02,0x00,0x04,0x00,0x06,0x00,0x08,0x00,0x0A,0x00,0x0C,0x00,0x0E,0x00,0x01,0x00,0x03,0x00,0x05,0x00,0x07,0x00,0x09,0x00,0x0B,0x00,0x0D,0x00,0x0F,0x00 };
        
        public static ReadOnlySpan<byte> ClearAlt256x8u 
            => new byte[n]{0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff,0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff};        
        
        public static ReadOnlySpan<byte> ClearAlt256x16u 
            => new byte[n]{0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff,0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff};

    }
}
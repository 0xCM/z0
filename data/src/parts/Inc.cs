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

        public static ReadOnlySpan<byte> Inc512x8u  
            => new byte[64]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
                16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,
                32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,
                48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63
                };

        public static ReadOnlySpan<byte> Inc512x16u  
            => new byte[64]{
                0,0,1,0,2,0,3,0,4,0,5,0,6,0,7,0,
                8,0,9,0,10,0,11,0,12,0,13,0,14,0,15,0,
                16,0,17,0,18,0,19,0,20,0,21,0,22,0,23,0,
                24,0,25,0,26,0,27,0,28,0,29,0,30,0,31,0
                };

        public static ReadOnlySpan<byte> Inc512x32u  
            => new byte[64]{
                0,0,0,0,1,0,0,0,2,0,0,0,3,0,0,0,
                4,0,0,0,5,0,0,0,6,0,0,0,7,0,0,0,
                8,0,0,0,9,0,0,0,A,0,0,0,B,0,0,0,
                C,0,0,0,D,0,0,0,E,0,0,0,F,0,0,0
                };

        public static ReadOnlySpan<byte> Inc512x64u  
            => new byte[64]{
                0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                2,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,
                4,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,
                6,0,0,0,0,0,0,0,7,0,0,0,0,0,0,0,
                };

        [DataRegistry]
        static void RegisterInc()
        {
            const string basename = "Inc";
            var w = default(ITypeNat);
            var index = IncIndex;

            w = n128;
            Register(index++, Identity.resource(basename, w, NumericKind.U8), Inc128x8u);
            Register(index++, Identity.resource(basename, w, NumericKind.U16), Inc128x16u);
            Register(index++, Identity.resource(basename, w, NumericKind.U32), Inc128x32u);
            Register(index++, Identity.resource(basename, w, NumericKind.U64), Inc128x64u);
            
            w = n256;
            Register(index++, Identity.resource(basename, w, NumericKind.U8), Inc256x8u);
            Register(index++, Identity.resource(basename, w, NumericKind.U16), Inc256x16u);
            Register(index++, Identity.resource(basename, w, NumericKind.U32), Inc256x32u);
            Register(index++, Identity.resource(basename, w, NumericKind.U64), Inc256x64u);
        }

    }
}
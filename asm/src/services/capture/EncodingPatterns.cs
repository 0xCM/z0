//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    
    using static zfunc;
    using static Z0.EncodingPatternKind;
    using static Z0.EncodingPatternTokens;
    
    using D = EncodingPatternOffset;

    public readonly struct EncodingPatterns : IBytePatternSet<EncodingPatternKind>
    {
        [MethodImpl(Inline)]
        public static EncodingPatterns Define()
            => new EncodingPatterns(0);

        readonly EncodingPatternKind[] FullKinds;

        readonly EncodingPatternKind[] PartialKinds;

        public int FullPatternCount {get;}

        public int PartialPatternCount {get;}

        public ReadOnlySpan<EncodingPatternKind> FullPatternKinds 
            => FullKinds;

        public ReadOnlySpan<EncodingPatternKind> PartialPatternKinds 
            => PartialKinds;
        
        EncodingPatterns(int dummy)
        {
             FullKinds = new EncodingPatternKind[]
             {
                CTC_RET_SBB,
                CTC_RET_INTR,
                CTC_RET_ZED_SBB,
                CTC_RET_Zx3,
                CTC_INTRx2,
                CTC_JMP_RAX,
                CTC_Zx7,
            };

            PartialKinds = new EncodingPatternKind[]
            {
                CTC_CALL32_INTR
            };

            FullPatternCount = FullKinds.Length;
            PartialPatternCount = PartialKinds.Length;
        }

        public ReadOnlySpan<byte> FullPattern(EncodingPatternKind code)
            => code switch{
                CTC_RET_SBB => RET_SBB,
                CTC_RET_INTR => RET_INT,
                CTC_RET_ZED_SBB =>  RET_ZED_SBB,              
                CTC_RET_Zx3 => RET_Zx2,
                CTC_INTRx2 => INTRx2,
                CTC_JMP_RAX => JMP_RAX,
                CTC_Zx7 => Z7,
                _ => Empty
            };

        public int MatchOffset(EncodingPatternKind code)
            => code switch{
                CTC_RET_SBB => (int)D.RET_SBB,
                CTC_RET_INTR => (int)D.RET_INT,
                CTC_RET_ZED_SBB => (int)D.RET_ZED_SBB,              
                CTC_RET_Zx3 => (int)D.RET_Zx3,
                CTC_INTRx2 => (int)D.RET_INTRx2,
                CTC_JMP_RAX => (int)D.JMP_RAX,
                CTC_Zx7 => (int)D.Z7,
                CTC_RET_Zx7 => (int)D.RET_Zx7,
                CTC_CALL32_INTR => (int)D.CTC_CALL32_INTR,
                _ => 0
            };

        public ReadOnlySpan<byte?> PartialPattern(EncodingPatternKind kind)
            => kind switch {
                CTC_CALL32_INTR => CALL32_INTR,
                _ => EmptyPartial
            };
        
        static ReadOnlySpan<byte> RET_SBB  => new byte[]{RET,SBB};

        static ReadOnlySpan<byte> RET_INT  => new byte[]{RET,INTR};

        static ReadOnlySpan<byte> RET_ZED_SBB => new byte[]{RET,ZED,SBB};

        static ReadOnlySpan<byte> RET_Zx2 => new byte[]{RET,ZED,ZED};

        static ReadOnlySpan<byte> INTRx2 => new byte[]{INTR,INTR};
        
        static ReadOnlySpan<byte> JMP_RAX => new byte[]{ZED,ZED,J48,FF,E0};

        static ReadOnlySpan<byte> Z7 => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};

        static ReadOnlySpan<byte?> CALL32_INTR => new byte?[]{CALL,null,null,null,null,INTR};

        static ReadOnlySpan<byte> Empty => new byte[]{};        

        static ReadOnlySpan<byte?> EmptyPartial => new byte?[]{};        
    }
}
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
    using static EncodingPatternKind;
    using static EncodingPatternTokens;
    
    using D = EncodingPatternDelta;

    public readonly struct EncodingPatterns : IBytePatternSet<EncodingPatternKind>
    {
        readonly EncodingPatternKind[] PatternKindList;
        
        public int PatternCount {get;}

        public EncodingPatterns(int dummy)
        {
             PatternKindList = new EncodingPatternKind[]
             {
                CTC_RET_SBB,
                CTC_RET_INTR,
                CTC_RET_ZED_SBB,
                CTC_RET_Zx3,
                CTC_INTRx2,
                CTC_JMP_RAX,
                CTC_Zx7
            };

            PatternCount = PatternKindList.Length;
        }

        ReadOnlySpan<EncodingPatternKind> IBytePatternSet<EncodingPatternKind>.PatternKinds 
            => PatternKindList;

        ReadOnlySpan<byte> IBytePatternSet<EncodingPatternKind>.Pattern(EncodingPatternKind code)
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

        int IBytePatternSet<EncodingPatternKind>.PatternValue(EncodingPatternKind code)
            => code switch{
                CTC_RET_SBB => (int)D.RET_SBB,
                CTC_RET_INTR => (int)D.RET_INT,
                CTC_RET_ZED_SBB => (int)D.RET_ZED_SBB,              
                CTC_RET_Zx3 => (int)D.RET_Zx3,
                CTC_INTRx2 => (int)D.RET_INTRx2,
                CTC_JMP_RAX => (int)D.JMP_RAX,
                CTC_Zx7 => (int)D.Z7,
                CTC_RET_Zx7 => (int)D.RET_Zx7,
                _ => 0
            };

        static ReadOnlySpan<byte> RET_SBB 
            => new byte[]{RET,SBB};

        static ReadOnlySpan<byte> RET_INT 
            => new byte[]{RET,INTR};

        static ReadOnlySpan<byte> RET_ZED_SBB
            => new byte[]{RET,ZED,SBB};

        static ReadOnlySpan<byte> RET_Zx2
            => new byte[]{RET,ZED,ZED};

        static ReadOnlySpan<byte> INTRx2
            => new byte[]{INTR,INTR};

        static ReadOnlySpan<byte> JMP_RAX
            => new byte[]{ZED,ZED,J48,FF,E0};

        static ReadOnlySpan<byte> Z7
            => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};

        static ReadOnlySpan<byte> Empty
            => new byte[]{};        
    }
}
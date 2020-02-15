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

        int IBytePatternSet<EncodingPatternKind>.PatternDelta(EncodingPatternKind code)
            => code switch{
                CTC_RET_SBB => RET_SBB_DELTA,
                CTC_RET_INTR => RET_INT_DELTA,
                CTC_RET_ZED_SBB => RET_ZED_SBB_DELTA,              
                CTC_RET_Zx3 => RET_Zx3_DELTA,
                CTC_INTRx2 => RET_INTRx2_DELTA,
                CTC_JMP_RAX => JMP_RAX_DELTA,
                CTC_Zx7 => Z7_DELTA,
                CTC_RET_Zx7 => RET_Zx7_Delta,
                _ => 0
            };

        const byte ZED = 0;
        
        const byte RET = 0xc3;
        
        const byte INTR = 0xcc;
        
        const byte SBB = 0x19;
        
        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        static ReadOnlySpan<byte> RET_SBB 
            => new byte[]{RET,SBB};

        const int RET_SBB_DELTA = -1;

        static ReadOnlySpan<byte> RET_INT 
            => new byte[]{RET,INTR};

        const int RET_INT_DELTA = -1;

        static ReadOnlySpan<byte> RET_ZED_SBB
            => new byte[]{RET,ZED,SBB};

        const int RET_ZED_SBB_DELTA = -2;

        static ReadOnlySpan<byte> RET_Zx2
            => new byte[]{RET,ZED,ZED};

        const int RET_Zx3_DELTA = -2;

        static ReadOnlySpan<byte> INTRx2
            => new byte[]{INTR,INTR};

        const int RET_INTRx2_DELTA = -2;

        static ReadOnlySpan<byte> JMP_RAX
            => new byte[]{ZED,ZED,J48,FF,E0};

        const int JMP_RAX_DELTA = 0;

        static ReadOnlySpan<byte> Z7
            => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};

        const int Z7_DELTA = -7;

        const int RET_Zx7_Delta = -6;

        static ReadOnlySpan<byte> Empty
            => new byte[]{};
    }

}
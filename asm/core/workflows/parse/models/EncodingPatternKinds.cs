//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum EncodingPatternOffset : int
    {
        None = 0,
        
        RET_SBB = -1,           
        
        RET_INT = -1,

        RET_ZED_SBB = -2,

        RET_Zx3 = -2,

        RET_INTRx2 = -2,

        CALL32_INTR = 0,
        
        JMP_RAX = 0,

        Z7 = -7,

        RET_Zx7 = -6,
    }

    public enum EncodingPatternKind : long
    {
        None = 0,

        RET_SBB = ExtractTermCode.CTC_RET_SBB,
        
        RET_INTR = ExtractTermCode.CTC_RET_INTR,

        RET_ZED_SBB = ExtractTermCode.CTC_RET_ZED_SBB,
        
        RET_Zx3 = ExtractTermCode.CTC_RET_Zx3,

        RET_Zx7 = ExtractTermCode.CTC_RET_Zx7,

        INTRx2 = ExtractTermCode.CTC_INTRx2,

        /// <summary>
        /// Identifies the pattern 00 00 00 00 00 00 00
        /// </summary>
        Zx7 = ExtractTermCode.CTC_Zx7,

        JMP_RAX = ExtractTermCode.CTC_JMP_RAX,
        
        /// <summary>
        /// Identifies the partial pattern e8 ?? ?? ?? ?? cc
        /// </summary>
        CALL32_INTR = 2*16
    }
    
    public static class EncodingPatternTokens
    {
        public const byte ZED = 0;

        public const byte FF = 0xff;

        public const byte RET_xC3 = 0xc3;
        
        public const byte INTR_xCC = 0xcc;
        
        public const byte SBB_x19 = 0x19;
        
        public const byte E0 = 0xe0;

        public const byte Jmp_x48 = 0x48;

        public const byte Call_xE8 = 0xe8;
    }

    public static class EncodingPatternKindOps
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;

        [MethodImpl(Inline)]
        public static bool IsPartial(this EncodingPatternKind code)
            => (uint)code >= 2*16;

        [MethodImpl(Inline)]
        public static ExtractTermCode ToTermCode(this EncodingPatternKind src)
            => (ExtractTermCode)src;
    }    

}
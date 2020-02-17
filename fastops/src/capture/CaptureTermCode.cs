//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines literals that indicate the reason for catpture termination
    /// </summary>
    public enum CaptureTermCode : byte
    {
        None = 0,

        CTC_RET_SBB,
        
        CTC_RET_INTR,

        CTC_RET_ZED_SBB,
        
        CTC_RET_Zx3,

        CTC_RET_Zx7,

        CTC_INTRx2,

        /// <summary>
        /// Identifies the pattern 00 00 00 00 00 00 00
        /// </summary>
        CTC_Zx7,

        CTC_JMP_RAX,

        CTC_BUFFER_OUT,

        CTC_MSDIAG,

        CTC_CALL32_INTR = 2*16,

    }

    public enum EncodingPatternKind : uint
    {
        None = 0,

        CTC_RET_SBB = CaptureTermCode.CTC_RET_SBB,
        
        CTC_RET_INTR = CaptureTermCode.CTC_RET_INTR,

        CTC_RET_ZED_SBB = CaptureTermCode.CTC_RET_ZED_SBB,
        
        CTC_RET_Zx3 = CaptureTermCode.CTC_RET_Zx3,

        CTC_RET_Zx7 = CaptureTermCode.CTC_RET_Zx7,

        CTC_INTRx2 = CaptureTermCode.CTC_INTRx2,

        /// <summary>
        /// Identifies the pattern 00 00 00 00 00 00 00
        /// </summary>
        CTC_Zx7 = CaptureTermCode.CTC_Zx7,

        CTC_JMP_RAX = CaptureTermCode.CTC_JMP_RAX,
        
        CTC_BUFFER_OUT = CaptureTermCode.CTC_BUFFER_OUT,

        CTC_MSDIAG = CaptureTermCode.CTC_MSDIAG,

        /// <summary>
        /// Identifies the pattern e8 _ _ _ _ cc
        /// </summary>
        CTC_CALL32_INTR = CaptureTermCode.CTC_CALL32_INTR,

    }

    public enum EncodingPatternDelta : int
    {
        None = 0,
        
        RET_SBB = -1,           
        
        RET_INT = -1,

        RET_ZED_SBB = -2,

        RET_Zx3 = -2,

        RET_INTRx2 = -2,

        CTC_CALL32_INTR = None,
        
        JMP_RAX = None,

        Z7 = -7,

        RET_Zx7 = -6,
    }
    
    public static class EncodingPatternTokens
    {
        public const byte ZED = 0;
        
        public const byte RET = 0xc3;
        
        public const byte INTR = 0xcc;
        
        public const byte SBB = 0x19;
        
        public const byte FF = 0xff;

        public const byte E0 = 0xe0;

        public const byte J48 = 0x48;

        public const byte CALL = 0xe8;
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
        public static CaptureTermCode ToTermCode(this EncodingPatternKind src)
            => (CaptureTermCode)src;
    }    
}
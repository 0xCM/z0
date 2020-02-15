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

        CTC_Zx7,

        CTC_JMP_RAX,
        
        CTC_BUFFER_OUT,

        CTC_MSDIAG,
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

        CTC_Zx7 = CaptureTermCode.CTC_Zx7,

        CTC_JMP_RAX = CaptureTermCode.CTC_JMP_RAX,
        
        CTC_BUFFER_OUT = CaptureTermCode.CTC_BUFFER_OUT,

        CTC_MSDIAG = CaptureTermCode.CTC_MSDIAG
    }

    public static class EncodingPatternKindOps
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;

        [MethodImpl(Inline)]
        public static CaptureTermCode ToTermCode(this EncodingPatternKind src)
            => (CaptureTermCode)src;
    }    
}
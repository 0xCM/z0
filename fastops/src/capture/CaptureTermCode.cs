//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Defines literals that indicate the reason for catpture termination
    /// </summary>
    public enum CaptureTermCode
    {
        None,

        CTC_RET_SBB,
        
        CTC_RET_INTR,

        CTC_RET_ZED_SBB,
        
        CTC_RET_Zx3,

        CTC_INTRx2,

        CTC_Zx7_000,

        CTC_Zx7_RET,

        CTC_JMP_RAX,

        CTC_MSDIAG,
        
        CTC_BUFFER_OUT
    }
}
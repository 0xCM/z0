//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;


    /// <summary>
    /// 
    /// </summary>
    public enum CaptureTermCode
    {
        None,

        RET_SBB,
        
        RET_INTR,

        RET_INTRx2,

        RET_ZED_SBB,
        
        RET_ZEDx3,

        INTRx2,

        ZEDx2_SBB,

        ZEDx6_000,

        ZEDx6_RET,

        ZEDx6_JMP,

        MSDIAG,

        EOB,
        
        /// <summary>
        /// Decoded all instructions
        /// </summary>
        DAI,

        Complete
    }
}
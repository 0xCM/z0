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

    public enum EncodingPatternKind : uint
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
        
        CTC_BUFFER_OUT
    }

    public static class EncodingPatternKindOps
    {
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;
    }

}
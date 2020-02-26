//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.Asm;

    using static zfunc;

    public interface IAsmTriggerSet
    {
        void FireOnMatch(AsmInstructionList instructions);
        
        void FireOnMatch(AsmFunction function);
    }

}
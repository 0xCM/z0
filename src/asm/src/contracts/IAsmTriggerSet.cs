//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;

    public interface IAsmTriggerSet
    {
        void FireOnMatch(in AsmInstructionList instructions);
        
        void FireOnMatch(in AsmFunction function);
    }
}
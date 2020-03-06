//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    public interface IAsmTriggerSet
    {
        void FireOnMatch(AsmInstructionList instructions);
        
        void FireOnMatch(AsmFunction function);
    }
}
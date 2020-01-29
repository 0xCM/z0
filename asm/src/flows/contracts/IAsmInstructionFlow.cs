//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    public interface IAsmInstructionSource
    {
        IEnumerable<AsmInstructionList> Instructions {get;}
    }

    public interface IAsmInstructionPipe
    {
        AsmInstructionList Flow(AsmInstructionList instruction);
    }

    public interface IAsmInstructionFlow
    {
        IEnumerable<AsmInstructionList> Flow(IAsmInstructionPipe pipe);
    }
}
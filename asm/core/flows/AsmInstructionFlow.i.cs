//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using Z0.Asm;

    public interface IAsmInstructionFlow
    {
        IEnumerable<AsmInstructionList> Flow(IAsmInstructionPipe pipe);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    public interface IAsmFunctionSource
    {
        IEnumerable<AsmFunction> Functions {get;}
    }

    public interface IAsmFunctionPipe
    {
        AsmFunction Flow(AsmFunction f);
    }

    public interface IAsmFunctionFlow
    {
        IEnumerable<AsmFunction>  Flow(IAsmFunctionPipe pipe);

        IEnumerable<AsmFunction> FlowDirect(IAsmFunctionPipe pipe);        

        IEnumerable<AsmFunction> FlowGeneric(IAsmFunctionPipe pipe);        
    }
}
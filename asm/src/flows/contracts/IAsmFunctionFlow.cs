//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.AsmSpecs;


    public interface IAsmFunctionPipe  : IObjectObserverPipe<AsmFunction>
    {
        
    }

    public interface IAsmFunctionFlow : IObjectObserverFlow<IAsmFunctionPipe, AsmFunction>
    {
    
        IEnumerable<AsmFunction> FlowDirect(IAsmFunctionPipe pipe);        

        IEnumerable<AsmFunction> FlowGeneric(IAsmFunctionPipe pipe);     

        IEnumerable<AsmFunction> Flow(IAsmFunctionPipe pipe);           
    }
}
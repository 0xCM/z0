//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Collections.Generic;
 
    using Z0.Asm;

    using static zfunc;
    
    public interface IAsmProcessCapture : IDisposable
    {
        IEnumerable<AsmFunction> CaptureFunctions(IEnumerable<MethodInfo> methods);   

        AsmFunction[] CaptureFunctions(Type src);                
    }

    public interface IAsmProcessEmitter
    {
        void EmitFunctions(Type host);
    }    
}
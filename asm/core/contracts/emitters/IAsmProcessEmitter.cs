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
    
    public interface IAsmProcessEmitter
    {
        void EmitFunctions(Type host);
    }    
}
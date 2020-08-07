//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Flow;
    
    public readonly struct WfCapture
    {
        public IAsmContext AsmContext {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public WfCapture(IAsmContext asm, CorrelationToken ct)
        {
            Ct = ct;
            AsmContext = asm;            
        }
    }
}
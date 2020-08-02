//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    using Z0.Asm;

    public interface IWfCapture : IContext
    {
        IAsmContext AsmContext {get;}

        IAppContext ContextRoot 
            => AsmContext.ContextRoot;
        
        TAppPaths AppPaths 
            => ContextRoot.AppPaths;
    }
    
    public readonly struct WfCapture : IWfCapture
    {
        public IAsmContext AsmContext {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public WfCapture(IAsmContext asm, CorrelationToken? ct = null)
        {
            Ct = correlate(ct);
            AsmContext = asm;            
        }
    }
}
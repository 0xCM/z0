//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Reflection;
    
    using static Konst;

    public ref partial struct EmitBitMasks 
    {
        readonly WfContext Wf;

        readonly CorrelationToken Correlation;
        
        public EmitBitMasks(WfContext context, CorrelationToken? ct = null)
        {
            Wf = context;
            Correlation = ct ?? CorrelationToken.create();
            Wf.Running(nameof(EmitBitMasks), Correlation);
        }

        public void Run()
        {
            ReflectedLiterals.emit(typeof(BitMasks), Wf.AppPaths);
        }
        
        public void Dispose()
        {
            Wf.Ran(nameof(EmitBitMasks), Correlation);

        }
    }
}

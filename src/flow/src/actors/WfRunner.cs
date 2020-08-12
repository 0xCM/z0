//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfRunner<A> : IWfRunner<A>
    {
        public IWfContext Wf {get;}
        
        readonly Action<A> Handler;        
        
        [MethodImpl(Inline)]
        public WfRunner(IWfContext wf, Action<A> handler)
        {
            Wf = wf;
            Handler = handler;
        }

        [MethodImpl(Inline)]
        public void Run(A args)        
            => Handler(args);
        
        public void Run()
        {

        }

        public void Dispose()
        {
            
        }
    }
}
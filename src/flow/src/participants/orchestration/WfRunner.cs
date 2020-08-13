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

    /// <summary>
    /// Executes an input-parametric action
    /// </summary>
    public readonly struct WfRunner<A> : IWfRunner<A>
        where A : struct
    {
        public const string ActorName = nameof(WfRunner<A>);
        
        public IWfContext Wf {get;}
        
        readonly Action<A> Handler;        
        
        readonly A? InitialArgs;
        
        [MethodImpl(Inline)]
        public WfRunner(IWfContext wf, Action<A> handler, A? args = null)
        {
            Wf = wf;
            Handler = handler;
            Wf.Created(ActorName, Wf.Ct);
            InitialArgs = args;
        }

        [MethodImpl(Inline)]
        public void Run(A args)        
        {
            Wf.RunningT(ActorName,args, Wf.Ct);
            try
            {
                Handler(args);
            }
            catch(Exception e)
            {
                Wf.Error(e, Wf.Ct);
            }
            
            Wf.RanT(ActorName,args, Wf.Ct);
        }
        
        [MethodImpl(Inline)]
        public void Run()
        {
            if(InitialArgs.HasValue)
                Run(InitialArgs.Value);
        }

        public void Dispose()
        {
            Wf.Finished(ActorName);
        }
    }
}
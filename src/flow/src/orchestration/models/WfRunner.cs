//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    /// <summary>
    /// Executes an input-parametric action
    /// </summary>
    public readonly struct WfRunner<A> : IWfRunner<A>
        where A : struct
    {
        public const string ActorName = nameof(WfRunner<A>);

        public IWfShell Wf {get;}

        readonly Action<A> Handler;

        readonly A? InitialArgs;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf, Action<A> handler, A? args = null)
        {
            Wf = wf;
            Handler = handler;
            InitialArgs = args;
            Wf.Created(typeof(A), Wf.Ct);
        }

        [MethodImpl(Inline)]
        public void Run(A args)
        {
            Wf.Running(typeof(A), args);

            try
            {
                Handler(args);
            }
            catch(Exception e)
            {
                Wf.Error(e, Wf.Ct);
            }

            Wf.Ran(typeof(A), args);
        }

        [MethodImpl(Inline)]
        public void Run()
        {
            if(InitialArgs.HasValue)
                Run(InitialArgs.Value);
        }

        public void Dispose()
        {
            Wf.Finished(typeof(A));
        }
    }
}
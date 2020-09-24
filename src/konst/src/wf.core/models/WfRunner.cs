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
    public readonly struct WfRunner<H>
        where H : IWfHost<H>, new()
    {
        public WfShellHost<H> Host {get;}

        public IWfShell Wf => Host.Wf;

        [MethodImpl(Inline)]
        public WfRunner(WfShellHost<H> host)
        {
            Host = host;

            Wf.Created(Host, Wf.Ct);
        }

        [MethodImpl(Inline)]
        public void Run(H args)
        {
            Wf.Running(Host, args);

            try
            {

            }
            catch(Exception e)
            {
                Wf.Error(e, Wf.Ct);
            }

            Wf.Ran(Host, args);
        }

        [MethodImpl(Inline)]
        public void Run()
        {

        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}
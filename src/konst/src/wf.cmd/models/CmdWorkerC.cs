//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdWorker<C> : ICmdWorkerHost<CmdWorker<C>, C>
        where C : struct, ICmdSpec<C>
    {
        readonly CmdWorkerFunction<C> Fx;

        [MethodImpl(Inline)]
        public CmdWorker(CmdWorkerFunction<C> fx)
            => Fx = fx;

        [MethodImpl(Inline)]
        public CmdResult Invoke(IWfShell wf, C cmd)
            => Fx(wf,cmd);

        public CmdResult Invoke(IWfShell wf, CmdSpec cmd)
            => @throw<CmdResult>(missing());

        [MethodImpl(Inline)]
        public static implicit operator CmdWorker<C>(CmdWorkerFunction<C> fx)
            => new CmdWorker<C>(fx);
    }
}
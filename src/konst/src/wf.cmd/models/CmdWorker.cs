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

    public readonly struct CmdWorker : ICmdWorkerHost<CmdWorker>
    {
        readonly CmdWorkerFunction Fx;

        [MethodImpl(Inline)]
        public CmdWorker(CmdWorkerFunction fx)
            => Fx = fx;

        [MethodImpl(Inline)]
        public CmdResult Invoke(IWfShell wf, CmdSpec cmd)
            => Fx(wf,cmd);

        [MethodImpl(Inline)]
        public static implicit operator CmdWorker(CmdWorkerFunction fx)
            => new CmdWorker(fx);
    }
}
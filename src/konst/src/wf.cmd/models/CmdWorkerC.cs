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

    public readonly struct CmdWorker<C> : ICmdWorker<CmdWorker<C>, C>
        where C : struct, ICmdSpec<C>
    {
        readonly CmdWorkerFunction<C> Fx;

        [MethodImpl(Inline)]
        public CmdWorker(CmdWorkerFunction<C> fx)
            => Fx = fx;

        public CmdId CmdId
            => default(C).Id;

        [MethodImpl(Inline)]
        public CmdResult Invoke(C cmd)
            => Fx(cmd);

        [MethodImpl(Inline)]
        public static implicit operator CmdWorker<C>(CmdWorkerFunction<C> fx)
            => new CmdWorker<C>(fx);
    }
}
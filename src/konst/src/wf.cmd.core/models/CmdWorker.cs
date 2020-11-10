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

    public readonly struct CmdWorker : ICmdWorker
    {
        readonly CmdWorkerFunction Fx;

        public CmdId CmdId {get;}

        [MethodImpl(Inline)]
        public CmdWorker(CmdId id, CmdWorkerFunction fx)
        {
            CmdId = id;
            Fx = fx;
        }

        [MethodImpl(Inline)]
        public CmdResult Invoke(ICmdSpec cmd)
            => Fx(cmd);
    }
}
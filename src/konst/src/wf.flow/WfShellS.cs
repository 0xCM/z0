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

    public readonly struct WfShell<S> : IWfShell<S>
    {
        readonly Paired<WfShell,S> Data;

        public IWfShell Shell => Data.Left;

        public S State => Data.Right;

        [MethodImpl(Inline)]
        public WfShell(WfShell wf, S state)
            => Data = (wf,state);
    }
}
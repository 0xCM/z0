//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfState<S> : IWfState<S>
    {
        public IWfShell Wf {get;}

        public S State {get;}

        [MethodImpl(Inline)]
        public WfState(IWfShell wf, S state)
        {
            Wf = wf;
            State = state;
        }
    }
}
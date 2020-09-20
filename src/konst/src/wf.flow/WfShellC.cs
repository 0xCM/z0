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

    public readonly struct WfShell<C> : IWfShell<C>
    {
        public IWfShell Shell {get;}

        public C Context {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfShell<C> ((IWfShell wf, C context) src)
            => new WfShell<C>(src.wf, src.context);

        [MethodImpl(Inline)]
        public WfShell(IWfShell wf, C context)
        {
            Shell = wf;
            Context = context;
        }
    }
}
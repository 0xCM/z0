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

    public abstract class WfHost<H,C> : WfHost<H>, IWfHost<H,C>
        where H : WfHost<H,C>, new()
    {
        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {

        }

        public override void Run(IWfShell shell)
            => throw new InvalidOperationException();

        public abstract void Run(IWfShell<C> wf);
    }
}
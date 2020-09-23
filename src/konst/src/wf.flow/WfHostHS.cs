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

    public abstract class WfHost<H,S> : WfHost<H>, IWfHost<H,S>
        where H : WfHost<H,S>, new()
    {
        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {

        }

        public void Run(IWfShell<S> wf)
        {
            try
            {
                Execute(wf);
            }
            catch(Exception e)
            {
                wf.Shell.Error(Id,e);
            }
        }

        protected abstract void Execute(IWfShell<S> wf);

        public override void Run(IWfShell shell)
            => throw new InvalidOperationException();
    }
}

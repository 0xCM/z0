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
        where S : new()
    {
        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {
            _State = new S[1]{new S()};
        }

        S[] _State;

        [MethodImpl(Inline)]
        public ref readonly S Configure(in S settings)
        {
            State = settings;
            return ref State;
        }

        protected ref S State
        {
            [MethodImpl(Inline)]
            get => ref _State[0];
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

        protected virtual void Execute(IWfShell wf, in S state)
            => Execute(wf);

        public void Run(IWfShell wf, in S state)
        {
            try
            {
                Configure(state);
                Execute(wf, state);
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        protected virtual void Execute(IWfShell<S> wf)
            => Run(wf.Shell, wf.State);
    }
}

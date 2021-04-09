//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

        protected virtual void Execute(IWfRuntime wf, in S src)
            => Execute(wf);

        protected override void Execute(IWfRuntime wf)
            => Execute(wf);

        public void Run(IWfRuntime wf, in S src)
        {
            try
            {
                Configure(src);
                Execute(wf, src);
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }
    }
}
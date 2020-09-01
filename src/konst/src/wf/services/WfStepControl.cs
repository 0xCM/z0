//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfStepControl : IWfStepControl
    {
        readonly Action Fx;

        public WfStepId StepId {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfStepControl((WfStepId id, Action fx) src)
            => new WfStepControl(src.id, src.fx);

        [MethodImpl(Inline)]
        public WfStepControl(WfStepId id, Action fx)
        {
            Fx = fx;
            StepId = id;
        }

        [MethodImpl(Inline)]
        public void Run()
            => Fx();
    }
}
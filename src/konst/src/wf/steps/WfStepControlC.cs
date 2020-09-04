//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfStepControl<C>
        where C : IWfStep<C>, new()
    {
        readonly Action Fx;

        public WfStepId Id => typeof(C);

        [MethodImpl(Inline)]
        public static implicit operator WfStepControl<C>(Action fx)
            => new WfStepControl<C>(fx);

        [MethodImpl(Inline)]
        public static implicit operator WfStepControl(WfStepControl<C> src)
            => new WfStepControl(src.Id, src.Fx);

        [MethodImpl(Inline)]
        public WfStepControl(Action fx)
            => Fx = fx;

        [MethodImpl(Inline)]
        public void Run()
            => Fx();
    }
}
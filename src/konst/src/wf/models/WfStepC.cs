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

    public readonly struct WfStep<C> : IWfStep<C>
        where C : struct, IWfStep<C>
    {
        public WfStepId Id {get;}

        [MethodImpl(Inline)]
        public WfStep(Type effect)
            => Id = Workflow.step(typeof(C));

        public Type Control
        {
            [MethodImpl(Inline)]
            get => Id.Control;
        }

        [MethodImpl(Inline)]
        public WfFunc<C> Fx([CallerMemberName] string name = null)
            => new WfFunc<C>(name);
    }
}
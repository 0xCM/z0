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
            => Id = AB.step(typeof(C), effect);

        public Type Control
        {
            [MethodImpl(Inline)]
            get => Id.Control;
        }

        public Type Effect
        {
            [MethodImpl(Inline)]
            get => Id.Effect;
        }

        [MethodImpl(Inline)]
        public WfFunc<C> Fx([CallerMemberName] string name = null)
            => new WfFunc<C>(name);

        public static implicit operator WfStep(WfStep<C> src)
            => new WfStep(src.Id);
    }
}
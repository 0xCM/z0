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

    public readonly struct WfStep : IWfStep
    {
        public WfStepId Id {get;}

        [MethodImpl(Inline)]
        public WfStep(WfStepId id)
        {
            Id = id;
        }

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
        public WfFunc<C> Fx<C>([CallerMemberName] string name = null)
            where C : struct, IWfStep<C>
                => new WfFunc<C>(name);
    }
}
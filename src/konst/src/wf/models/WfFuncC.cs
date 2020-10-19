//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfFunc<C> : IWfFunc<C>
        where C : IWfStep<C>, new()
    {
        public StringRef Name {get;}

        public WfStepId StepId
        {
            [MethodImpl(Inline)]
            get => Step.Id;
        }

        public C Step => default;

        [MethodImpl(Inline)]
        public static implicit operator WfFunc(WfFunc<C> src)
            => new WfFunc(src.StepId, src.Name);

        [MethodImpl(Inline)]
        public static implicit operator WfFunc<C>(string name)
            => new WfFunc<C>(name);

        [MethodImpl(Inline)]
        public WfFunc([CallerMemberName] string name = null)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());
    }
}
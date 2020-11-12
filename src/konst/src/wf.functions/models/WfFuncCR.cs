//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FS;

    public readonly struct WfFunc<C,R> : IWfFunc<C>
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
        public WfFunc([CallerMemberName] string name = null)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());

        public static implicit operator WfFunc(WfFunc<C,R> src)
            => new WfFunc(src.StepId, src.Name);
    }
}
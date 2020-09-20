//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfAction<C> : IWfAction
        where C : struct, IWfStep<C>
    {
        public StringRef Name {get;}

        public WfStepId StepId
        {
            [MethodImpl(Inline)]
            get => Step.Id;
        }

        [MethodImpl(Inline)]
        public WfAction([CallerMemberName] string name = null)
            => Name = name;

        public C Step => default;

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfFunc : IWfFunc
    {
        public StringRef Name {get;}

        public WfStepId StepId {get;}

        [MethodImpl(Inline)]
        public WfFunc(WfStepId step, string name)
        {
            StepId = step;
            Name = name;
        }

        [MethodImpl(Inline)]
        public WfFunc(WfStepId step, StringRef name)
        {
            StepId = step;
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfFunc((WfStepId step, string name) src)
            => new WfFunc(src.step, src.name);

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());
    }
}
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

    public readonly struct WfStepArgs : IWfStepArgs<WfStepArgs, WfStepArg>
    {
        readonly TableSpan<WfStepArg> Data;

        [MethodImpl(Inline)]
        public static implicit operator WfStepArgs(WfStepArg[] src)
            => new WfStepArgs(src);

        [MethodImpl(Inline)]
        public WfStepArgs(params WfStepArg[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<WfStepArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}
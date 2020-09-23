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

    public readonly struct WfStepArgs
    {
        readonly TableSpan<WfStepArg> Data;

        [MethodImpl(Inline)]
        public static implicit operator WfStepArgs(WfStepArg[] src)
            => new WfStepArgs(src);

        [MethodImpl(Inline)]
        public static implicit operator WfStepArg[](WfStepArgs src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public WfStepArgs(params WfStepArg[] src)
            => Data = src;

        [MethodImpl(Inline)]
        WfStepArgs(int i)
        {
            Data = TableSpan<WfStepArg>.Empty;
        }

        public ReadOnlySpan<WfStepArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public static WfStepArgs Empty
            => new WfStepArgs(0);
    }
}
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
        public readonly TableSpan<WfStepArg> Data;

        [MethodImpl(Inline)]
        public static implicit operator WfStepArgs(WfStepArg[] src)
            => new WfStepArgs(src);

        [MethodImpl(Inline)]
        public WfStepArgs(WfStepArg[] src)
        {
            Data = src;
        }        
    }
}
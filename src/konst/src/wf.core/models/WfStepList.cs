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

    public readonly struct WfStepList
    {
        readonly TableSpan<WfStepInfo> Data;

        [MethodImpl(Inline)]
        public WfStepList(WfStepInfo[] src)
        {
            Data = src;
        }
    }
}
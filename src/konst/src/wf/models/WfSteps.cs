//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    public readonly struct WfStepIndex
    {
        readonly TableSpan<WfStepInfo> Storage;

        [MethodImpl(Inline)]
        public WfStepIndex(WfStepInfo[] src)
        {
            Storage = src;
        }
    }
}
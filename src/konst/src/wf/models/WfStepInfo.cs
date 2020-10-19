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

    public struct WfStepInfo
    {
        public WfStepId Id;

        [MethodImpl(Inline)]
        public WfStepInfo(WfStepId id)
        {
            Id = id;
        }
    }
}
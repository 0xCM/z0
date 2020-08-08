//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct WfBuilder
    {
        [MethodImpl(Inline), Op]
        public static WfState state(IWfContext wf, IAsmContext asm, WfConfig config)         
            => new WfState(wf, asm, config, wf.Ct);
    }
}
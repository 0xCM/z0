//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static WfCore;

    [WfHost]
    public sealed class EmitExtractReport : WfHost<EmitExtractReport>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }
}
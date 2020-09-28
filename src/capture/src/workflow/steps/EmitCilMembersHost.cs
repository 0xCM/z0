//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    [WfHost]
    public sealed class EmitCilMembersHost : WfHost<EmitCilMembersHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }
}
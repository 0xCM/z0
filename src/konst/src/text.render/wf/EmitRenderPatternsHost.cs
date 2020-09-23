//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public sealed class EmitRenderPatternsHost : WfHost<EmitRenderPatternsHost, DataFlow<Type, FS.FilePath>>
    {
        protected override void Execute(IWfShell<DataFlow<Type,FS.FilePath>> wf)
        {
            using var step = new EmitRenderPatterns(wf.Shell, this, wf.State);
            step.Run();
        }
    }
}
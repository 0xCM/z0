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

    [WfHost]
    public sealed class EmitLiteralsHost : WfHost<EmitLiteralsHost>
    {

    }

    [WfHost]
    public sealed class EmitImageHeadersHost : WfHost<EmitImageHeadersHost, DataFlow<FS.Files, FS.FilePath>>
    {
        protected override void Execute(IWfShell<DataFlow<FS.Files, FS.FilePath>> wf)
        {
            using var step = new EmitImageHeaders(wf.Shell, this, wf.State);
            step.Run();
        }
    }

    public sealed class EmitModuleReportHost : WfHost<EmitModuleReportHost>
    {

    }

}
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
        public override void Run(IWfShell wf, DataFlow<FS.Files, FS.FilePath> state)
        {
            using var step = new EmitImageHeaders(wf, this, state);
            step.Run();
        }
    }

    public sealed class EmitModuleReportHost : WfHost<EmitModuleReportHost, FS.FilePath>
    {

        public override void Run(IWfShell wf, FS.FilePath dst)
        {

        }
    }

}
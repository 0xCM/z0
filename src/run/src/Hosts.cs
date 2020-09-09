//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [WfHost]
    public sealed class EmitLiteralsHost : WfHost<EmitLiteralsHost>
    {

    }

    [WfHost]
    public sealed class EmitImageHeadersHost : WfHost<EmitImageHeadersHost, WfDataFlow<FS.Files, FS.FilePath>>
    {
        public override void Run(IWfShell wf, WfDataFlow<FS.Files, FS.FilePath> state)
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
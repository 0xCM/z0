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

    public ref struct EmitModuleReport
    {

        readonly IWfShell Wf;

        public readonly FS.FilePath Target;

        public EmitModuleReport(IWfShell wf)
        {
            Wf = wf;
            Target = Wf.Paths.AppLogRoot + FS.file("ModuleReport", FS.Extensions.Csv);
        }

        public void Execute()
        {
            using var process = Handles.process();

        }


    }
}
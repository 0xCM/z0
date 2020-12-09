//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;

    public struct WfWorkers : IWfService<WfWorkers>
    {
        WfHost Host;

        IWfShell Wf;

        [Op]
        public void list(IWfShell wf, BuildArchiveSettings spec)
        {
            var archive = BuildArchives.create(wf, spec);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib);
            var cmd = EmitFileListCmd.specify(wf, spec.Label + ".artifacts", archive.Root, types);
            EmitFileList.run(wf, cmd);
        }

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(typeof(WfWorkers));
            Wf = wf.WithHost(Host);
        }
    }
}
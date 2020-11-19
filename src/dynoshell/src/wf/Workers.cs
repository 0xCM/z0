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
    using static Konst;

    public struct Workers : IWfService<Workers>
    {
        WfHost Host;

        IWfShell Wf;

        [Op]
        public void list(IWfShell wf, BuildArchiveSettings spec)
        {
            var archive = BuildArchives.create(wf, spec);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib);
            var cmd = EmitFileList.specify(wf, spec.Label + ".artifacts", archive.Root, types);
            EmitFileList.run(wf, cmd);
        }

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(typeof(Workers));
            Wf = wf.WithHost(Host);
        }

        public CmdResult Route(EmitHexIndexCmd cmd)
        {
            var dst = Wf.Db().Table("apihex.index");
            var descriptors = ApiCode.BlockDescriptors(Wf);
            var count= ApiCode.emit(descriptors, dst);
            Wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            return Cmd.ok(cmd);
        }

    }
}
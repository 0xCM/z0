//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    sealed class PipeApiHexFiles : CmdReactor<PipeApiHexFiles,PipeApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(PipeApiHexFilesCmd cmd)
        {
            var archive = ApiArchives.hex(Wf);
            var files = archive.List();
            Wf.Status(string.Format("Discovered {0} files in {1}", files.Count, archive.Root));
            z.iter(archive.List().Storage, file => Wf.Status(file));
            return Cmd.ok(cmd);
        }
    }
}

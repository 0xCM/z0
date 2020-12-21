//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class ListApiHexFiles : CmdReactor<ListApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(ListApiHexFilesCmd cmd)
            => react(Wf,cmd);

        [Op]
        static CmdResult react(IWfShell wf, ListApiHexFilesCmd cmd)
        {
            var archive = WfArchives.hex(wf);
            var files = archive.List();
            wf.Status(string.Format("Discovered {0} files in {1}", files.Count, archive.Root));
            z.iter(archive.List().Storage, file => wf.Status(file));
            return Cmd.ok(cmd);
        }
    }
}
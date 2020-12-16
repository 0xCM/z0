//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class PipeApiHexFiles : CmdReactor<PipeApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(PipeApiHexFilesCmd cmd)
            => react(Wf,cmd);

        [Op]
        static CmdResult react(IWfShell wf, PipeApiHexFilesCmd cmd)
        {
            var archive = WfArchives.hex(wf);
            var files = archive.Listing();
            wf.Status(string.Format("Discovered {0} files in {1}", files.Count, archive.Root));
            z.iter(archive.Listing().Storage, file => wf.Status(file));
            return Cmd.ok(cmd);
        }
    }
}
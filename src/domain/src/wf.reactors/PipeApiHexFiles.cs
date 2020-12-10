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
        public static CmdResult react(IWfShell wf, PipeApiHexFilesCmd cmd)
        {
            var archive = ApiArchives.hex(wf);
            var files = archive.List();
            wf.Status(string.Format("Discovered {0} files in {1}", files.Count, archive.Root));
            z.iter(archive.List().Storage, file => wf.Status(file));
            return Cmd.ok(cmd);
        }
    }
}
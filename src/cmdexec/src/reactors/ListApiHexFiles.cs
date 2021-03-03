//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class ListApiHexFiles : CmdReactor<ListApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(ListApiHexFilesCmd cmd)
        {
            var archive = Wf.ApiHexArchive();
            root.iter(archive.Files(), file => Wf.Row(file.ToUri()));
            return Cmd.ok(cmd);
        }
    }
}
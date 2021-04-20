//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    sealed class ShowRuntimeArchive : CmdReactor<ShowRuntimeArchiveCmd, CmdResult>
    {
        protected override CmdResult Run(ShowRuntimeArchiveCmd cmd)
        {
            var archive = Wf.RuntimeArchive();
            root.iter(archive.DllFiles, f => Wf.Row(f.ToUri()));
            root.iter(archive.PdbFiles, f => Wf.Row(f.ToUri()));
            root.iter(archive.XmlFiles, f => Wf.Row(f.ToUri()));
            root.iter(archive.JsonFiles, f => Wf.Row(f.ToUri()));
            return Cmd.ok(cmd);
        }
    }
}

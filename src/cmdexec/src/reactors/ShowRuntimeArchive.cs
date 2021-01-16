//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Part;
    using static z;

    sealed class ShowRuntimeArchive : CmdReactor<ShowRuntimeArchiveCmd, CmdResult>
    {
        protected override CmdResult Run(ShowRuntimeArchiveCmd cmd)
        {
            var archive = Wf.RuntimeArchive();
            iter(archive.DllFiles, f => Wf.Row(f.ToUri()));
            iter(archive.PdbFiles, f => Wf.Row(f.ToUri()));
            iter(archive.XmlFiles, f => Wf.Row(f.ToUri()));
            iter(archive.JsonFiles, f => Wf.Row(f.ToUri()));
            return Cmd.ok(cmd);
        }
    }
}

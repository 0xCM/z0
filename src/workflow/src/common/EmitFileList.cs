//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitFileList : CmdReactor<ListFilesCmd>
    {
        protected override CmdResult Run(ListFilesCmd cmd)
        {
            var list = Archives.list(cmd.SourceDir, cmd.Extensions, cmd.EmissionLimit);
            var outcome = Archives.emit(list, cmd.FileUriMode, cmd.TargetPath);
            return outcome ? Cmd.ok(cmd) : Cmd.fail(cmd, outcome.Message);
        }
    }
}
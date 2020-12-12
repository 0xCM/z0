//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitCilCmd : ICmdSpec<EmitCilCmd>
    {
        public const string CmdName = "emit-cil";
        public FS.Files Source;

        public FS.FilePath SummaryTarget;

        public FS.FilePath CilTarget;
    }
}
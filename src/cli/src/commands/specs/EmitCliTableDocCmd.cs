//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitCliTableDocCmd : ICmdSpec<EmitCliTableDocCmd>
    {
        public const string CmdName = "emit-cli-tabledoc";

        public FS.FilePath Source;

        public FS.FilePath Target;
    }
}
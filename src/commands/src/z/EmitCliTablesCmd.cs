//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitCliTablesCmd : ICmdSpec<EmitCliTablesCmd>
    {
        public const string CmdName = "emit-cli-tables";

        public FS.FilePath Source;

        public FS.FilePath Target;
    }
}
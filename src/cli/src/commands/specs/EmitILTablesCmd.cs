//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitILTablesCmd : ICmdSpec<EmitILTablesCmd>
    {
        public const string CmdName = "emit-il-tables";

        public FS.FilePath Source;

        public FS.FilePath Target;
    }
}
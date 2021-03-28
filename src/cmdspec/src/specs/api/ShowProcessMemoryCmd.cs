//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct ShowProcessMemoryCmd : ICmd<ShowProcessMemoryCmd>
    {
        public const string CmdName = "show-process-memory";
    }

    partial class XCmd
    {
        [Op]
        public static ShowProcessMemoryCmd ShowProcessMemory(this WfCmdBuilder builder)
            => new ShowProcessMemoryCmd();
    }
}
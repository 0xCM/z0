//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".commands")]
        Outcome Commands(CmdArgs args)
        {
            var commands = Cmd.cmdops(GetType());
            iter(commands, cmd => Write(cmd.Format()));
            return true;
        }
    }
}
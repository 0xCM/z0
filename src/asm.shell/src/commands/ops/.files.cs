//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".files")]
        Outcome ShowFiles(CmdArgs args)
        {
            var result = Outcome.Success;
            var files = State.Files();
            iter(files, file => Write(file.ToUri()));
            return result;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-asm")]
        Outcome ApiAsm(CmdArgs args)
        {
            var part = arg(args,0);
            var outcome = ApiParsers.part(part.Value, out var id);
            if(outcome.Fail)
                return outcome;

            LoadApiAsmPaths(id);
            return ReadAsciLines();
        }
    }
}
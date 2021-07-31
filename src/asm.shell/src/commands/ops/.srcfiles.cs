//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".srcfiles")]
        Outcome SrcFiles(CmdArgs args)
        {
            var result = Outcome.Success;
            ProjectId id = arg(args,0).Value;
            Files(Projects().SrcFiles(id));
            return result;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dataset")]
        Outcome Dataset(CmdArgs args)
        {
            var result = Outcome.Success;
            Files(DataSources.Datasets(arg(args,0).Value).Files(true));
            return result;
        }
    }
}
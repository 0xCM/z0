//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".datasets")]
        Outcome Datasets(CmdArgs args)
        {
            var src = Sources().Datasets().SubDirs();
            iter(src, dir => Write(dir));
            return true;
        }

        [CmdOp(".dataset")]
        Outcome Dataset(CmdArgs args)
        {
            var result = Outcome.Success;
            Files(Sources().Dataset(arg(args,0).Value).Files(true));
            return result;
        }
    }
}
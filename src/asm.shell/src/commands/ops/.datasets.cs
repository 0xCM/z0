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
    }
}
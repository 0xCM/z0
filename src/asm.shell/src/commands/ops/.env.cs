//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".env")]
        Outcome ShowEnv(CmdArgs args)
        {
            var vars = Z0.Env.vars();
            iter(vars, v => Wf.Row(v));
            return true;
        }
    }
}
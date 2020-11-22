//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class CheckBitMasksReactor : CmdReactor<CheckBitMasksCmd,CmdResult>
    {
        protected override CmdResult Run(CheckBitMasksCmd cmd)
        {
            var log = text.build();
            using var step = new BitMaskChecker(Wf, Host, Wf.PolySource, log);
            step.Run();
            return Cmd.ok(cmd);
        }
    }
}
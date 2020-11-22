//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class EmitAsmOpCodes : CmdReactor<EmitAsmOpCodesCmd, FS.FilePath>
    {
        protected override FS.FilePath Run(EmitAsmOpCodesCmd cmd)
            => Reactions.react(Wf,cmd);
    }
}
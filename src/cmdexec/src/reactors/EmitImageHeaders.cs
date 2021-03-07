//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class EmitImageHeaders : CmdReactor<EmitImageHeadersCmd, CmdResult>
    {
        protected override CmdResult Run(EmitImageHeadersCmd cmd)
            => ImageDataEmitter.create(Wf).EmitImageHeaders(cmd.Source, cmd.Target).ToCmdResult(cmd);
    }
}
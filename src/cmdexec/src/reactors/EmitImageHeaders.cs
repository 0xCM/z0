//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class EmitImageHeaders : CmdReactor<EmitImageHeadersCmd, CmdResult>
    {
        protected override CmdResult Run(EmitImageHeadersCmd cmd)
            => ImageDataEmitter.create(Wf).EmitSectionHeaders(cmd.Source, cmd.Target).ToCmdResult(cmd);
    }
}
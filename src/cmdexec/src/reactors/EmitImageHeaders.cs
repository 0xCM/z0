//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    class EmitImageHeaders : CmdReactor<EmitImageHeadersCmd, CmdResult>
    {
        protected override CmdResult Run(EmitImageHeadersCmd cmd)
            => ImageEmitters.init(Wf).EmitSectionHeaders(cmd.Source, cmd.Target).ToCmdResult(cmd);
    }
}
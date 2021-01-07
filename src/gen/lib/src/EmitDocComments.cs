
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Dev;

    sealed class EmitDocComments : CmdReactor<EmitDocCommentsCmd>
    {
        protected override CmdResult Run(EmitDocCommentsCmd cmd)
        {
            var collected = CommentCollector.collect(Wf);
            var msg = string.Format("Collected documentation for {0} parts", collected.Count);
            return Cmd.ok(cmd, msg);
        }
    }
}
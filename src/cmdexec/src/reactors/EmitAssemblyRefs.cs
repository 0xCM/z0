//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitAssemblyRefs : CmdReactor<EmitAssemblyRefsCmd>
    {
        protected override CmdResult Run(EmitAssemblyRefsCmd cmd)
        {
            using var emitter = ImageDataEmitter.init(Wf);
            emitter.EmitAssemblyRefs(cmd.Sources, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}
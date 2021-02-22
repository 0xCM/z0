//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    sealed class EmitImageContent : CmdReactor<EmitImageContentCmd>
    {
        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);

        protected override CmdResult Run(EmitImageContentCmd cmd)
        {
            var flow = Wf.EmittingFile(cmd.Target);
            var service = MemoryEmitter.create(Wf);
            service.EmitPaged(cmd.Source.BaseAddress, cmd.Source.Size, cmd.Target);
            Wf.EmittedFile(flow);
            return Cmd.ok(cmd);
        }
    }
}
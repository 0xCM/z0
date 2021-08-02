//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".gen-rex-bits")]
        Outcome EmitRexFields(CmdArgs args)
        {
            var path = Gen().Path("bitfields", "rex", FS.ext("bits"));
            var flow = Wf.EmittingFile(path);
            var bits = RexPrefix.Range();
            using var writer = path.AsciWriter();
            var buffer = text.buffer();
            var count = AsmRender.RexTable(buffer);
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow,count);
            return true;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".emit-rex-bits")]
        Outcome EmitRexFields(CmdArgs args)
        {
            var path = Workspace.Bitfield("rex");
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
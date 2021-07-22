//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".emit-modrm-bits")]
        Outcome EmitModRmFields(CmdArgs args)
        {
            var path = Workspace.Bitfield("modrm");
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = AsmRender.modRmBits(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return true;
        }
    }
}
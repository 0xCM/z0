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
            var path = GenWs().Path("bitfields", "rex", FS.ext("bits"));
            var flow = Wf.EmittingFile(path);
            var bits = RexPrefix.Range();
            using var writer = path.AsciWriter();
            var buffer = text.buffer();
            var count = AsmRender.RexTable(buffer);
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow,count);
            return true;
        }

        [CmdOp(".gen-bit-seq")]
        Outcome EmitBitSeq(CmdArgs args)
        {
            const byte CellWidth = 8;
            const uint CellCount = 256;
            Span<char> buffer = stackalloc char[CellWidth];
            var dst = GenWs().WsRoot() + FS.file("bitseq", FS.Cs);
            var flow = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            writer.WriteLine("    public readonly struct GeneratedBits");
            writer.WriteLine("    {");
            writer.Write(string.Format("        public static ReadOnlySpan<byte> SequencedBits = new byte[{0}]", CellCount));
            writer.Write("{");
            for(var i=0; i<CellCount; i++)
            {
                byte b = (byte)i;
                var data = text.format(render(b, CellWidth, buffer));
                writer.Write(string.Format("0b{0}, ", data));
            }
            writer.WriteLine("};");
            writer.WriteLine("    }");
            EmittedFile(flow, CellCount);
            return true;
        }

        [MethodImpl(Inline), Op]
        static Span<char> render(byte src, byte width, Span<char> dst)
        {
            for(var j=0; j<width; j++)
                seek(dst, j) = @char(@bool(bit.test(src, (byte)j)));
            dst.Reverse();
            return dst;
        }
    }
}
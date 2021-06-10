//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static Typed;
    using static core;

    public class AsmIndexWorker : IReceiver<AsmIndex>, IDisposable
    {
        const string RenderPattern = "{0,-12} | {1,-32} | {2,-22} | {3,-36} | {4,-8} | {5,-32} | {6}";

        public FS.FilePath Target {get;}

        readonly Index<char> _Buffer;

        readonly StreamWriter Writer;

        public AsmIndexWorker(FS.FilePath dst)
        {
            Target = dst;
            _Buffer = alloc<char>(256);
            Writer = dst.Writer(Encoding.ASCII);
            Writer.WriteLine(RenderPattern, "Sequence", "Sig", "OpCode", "Statement", "Size", "Hex", "Bitstring");
        }

        Span<char> GetBuffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }

        string Format(in AsmIndex src)
        {
            ref readonly var encoded = ref src.Encoded;
            ref readonly var seq = ref src.Sequence;
            var size = encoded.Size;
            var bitstring = AsmBitstrings.bitchars(n3, encoded).Format();
            var i=0u;
            var buffer = GetBuffer();
            var count = AsmRender.render(encoded, ref i, buffer);
            var hex = text.format(slice(buffer,0,count));
            var content = string.Format(RenderPattern, seq, src.Sig, src.OpCode, src.Expression, size, hex, bitstring);
            return content;
        }


        [MethodImpl(Inline), Op]
        public static bit HasRex(in AsmOpCodeExpr src)
            => src.Data.Contains("REX", StringComparison.InvariantCultureIgnoreCase);


        public void Deposit(in AsmIndex src)
        {
            var opcode = src.OpCode;
            if(HasRex(opcode))
            {
                Writer.WriteLine(Format(src));
            }

        }

        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
        }
    }
}
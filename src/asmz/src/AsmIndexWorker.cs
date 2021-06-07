//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;
    using System.IO;

    using static Root;
    using static Typed;
    using static core;

    public class AsmIndexWorker : IReceiver<AsmIndex>, IDisposable
    {
        const string RenderPattern = "{0,-12} | {1,-22} | {2,-8} | {3,-32} | {4}";

        public FS.FilePath Target {get;}

        readonly Index<char> _Buffer;

        readonly StreamWriter Writer;

        public AsmIndexWorker(FS.FilePath dst)
        {
            Target = dst;
            _Buffer = alloc<char>(256);
            Writer = dst.Writer(Encoding.ASCII);
            Writer.WriteLine(RenderPattern, "Sequence", "Mnemonic", "Size", "Hex", "Bitstring");
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
            var content = string.Format(RenderPattern, seq, src.Sig.Mnemonic, size, hex, bitstring);
            return content;
        }

        public void Deposit(in AsmIndex src)
        {
            Writer.WriteLine(Format(src));
        }

        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
        }
    }
}
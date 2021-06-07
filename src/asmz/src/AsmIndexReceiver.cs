//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;
    using System.IO;

    using static Part;
    using static core;

    public struct AsmIndexReceiver : IReceiver<AsmIndex>, IDisposable
    {
        const string RenderPattern = "{0,-12} | {1,-8} | {2,-32} | {3,-32} | {4}";

        public FS.FilePath Target {get;}

        readonly Index<char> _Buffer;

        readonly StreamWriter Writer;

        public AsmIndexReceiver(FS.FilePath dst)
        {
            Target = dst;
            _Buffer = alloc<char>(256);
            Writer = dst.Writer(Encoding.ASCII);
            Writer.WriteLine(RenderPattern, "Sequence", "Size", "Hex0", "Hex1", "Bitstring");
        }

        Span<char> GetBuffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }

        public void Deposit(in AsmIndex src)
        {
            ref readonly var encoded = ref src.Encoded;
            ref readonly var seq = ref src.Sequence;
            var size = encoded.Size;
            var bitstring = AsmBitstrings.bitchars(n3, encoded).Format();
            var hex1 = encoded.Format();
            var i=0u;
            var buffer = GetBuffer();
            var count = AsmRender.render(encoded,ref i, buffer);
            var hex2 = text.format(slice(buffer,0,count));
            var content = string.Format(RenderPattern, seq, size, hex1, hex2, bitstring);
            Writer.WriteLine(content);
        }

        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
        }
    }
}
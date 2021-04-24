//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using K = BitCmdKind;

    public sealed class BitCmdHost : AppCmdHost<BitCmdHost,K>
    {
        void ShowBitSeq(N1 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        void ShowBitSeq(N2 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        void ShowBitSeq(N3 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        void ShowBitSeq(N4 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        void ShowBitSeq(N5 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        void ShowBitSeq(N6 n, ShowLog dst)
        {
            var bits = BitSeq.bits(n);
            dst.Show($"n={n}, count={bits.Length}");
            dst.Show(RP.PageBreak120);
            root.iter(bits, s => dst.Buffer.AppendFormat("{0} ", s.Format()));
            dst.ShowBuffer();
        }

        [Action(K.ShowBitSequences)]
        void ShowBitSequences()
        {
            using var log = ShowLog("bitseq", FS.Log);
            ShowBitSeq(w1, log);
            ShowBitSeq(w2, log);
            ShowBitSeq(w3, log);
            ShowBitSeq(w4, log);
            ShowBitSeq(w5, log);
            ShowBitSeq(w6, log);
        }

        [MethodImpl(Inline), Op]
        static Span<char> render(byte src, Span<char> dst)
        {
            for(var j=0; j<8; j++)
                seek(dst, j) = @char(@bool(bit.test(src, (byte)j)));
            dst.Reverse();
            return dst;
        }

        [Action(K.GenBitSequences)]
        void GenBitSequences()
        {
            Span<char> buffer = stackalloc char[8];
            var dst = Db.Doc("bitseq", FS.Cs);
            using var writer = dst.Writer();
            writer.WriteLine("    public readonly struct GeneratedBits");
            writer.WriteLine("    {");
            writer.Write("        public static ReadOnlySpan<byte> SequencedBits = new byte[256]{");
            for(var i=0; i<255; i++)
            {
                byte b = (byte)i;
                var data = text.format(render(b,buffer));
                writer.Write(string.Format("0b{0}, ", data));
            }
            writer.WriteLine("};");
            writer.WriteLine("    }");
        }
    }

    public static partial class XTend
    {
        public static BitCmdHost BitCmd(this IWfRuntime wf)
            => BitCmdHost.create(wf);
    }
}
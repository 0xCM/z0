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

    public sealed class BitCmdHost : WfCmdHost<BitCmdHost,K>
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
            using var log = ShowLog("bitseq", FS.Extensions.Log);
            ShowBitSeq(w1, log);
            ShowBitSeq(w2, log);
            ShowBitSeq(w3, log);
            ShowBitSeq(w4, log);
            ShowBitSeq(w5, log);
            ShowBitSeq(w6, log);
        }
    }

    partial class XTend
    {
        public static BitCmdHost BitCmd(this IWfShell wf)
            => BitCmdHost.create(wf);
    }
}


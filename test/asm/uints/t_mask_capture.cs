//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public sealed class t_mask_capture : t_asm<t_mask_capture>
    {
        public static T[] binlits<T>(Type declarer, Action<AppMsg> msg)
            where T : unmanaged
        {
            var literals = Literals.tagged<T>(Konst.base2, declarer).Table;
            var count = literals.Length;
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                var mask = literals[i];
                var bits = BitSpans.parse32(mask.Text);
                var bitval = bits.Convert<T>();
                if(gmath.neq(bitval, mask.Data))
                    msg(AppMsg.error($"{bitval} != {mask.Data}"));
            }

            return buffer;
        }

        public void check_bit_masks()
        {
            var src = typeof(BitMasks.Literals);
            var data = binlits<ulong>(src, msg => Trace(msg));
            Trace(data.Length);

        }

        public void test_bit_parse()
        {
            var src = Random.Bytes(8).Array();
            var formatted = BitFormatter.chars(src);
            Trace(formatted.ToString());
        }

        public void digital_render()
        {
            var src = Random.Bytes(8).ToSpan();
            var bs = src.ToBitSpan();
            Claim.eq(64, bs.Length);
            var expect = bs.Format();
            var actual = Digital.render(Konst.base2, src).Reverse().ToString();
            ClaimPrimal.eq(expect,actual);
        }

        public void capture_natural_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();

            foreach(var src in MaskCases.NaturalClosures)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();
                hexout.Write(captured.CodeBlock);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }
        }
    }
}
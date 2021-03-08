//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class t_digital : t_symbolic<t_digital>
    {
        public void t_pow2()
        {
            var path = CasePath(CsvExt);
            var flow = Wf.EmittingFile(path);
            using var writer = path.Writer();
            for(byte i=0; i<64; i++)
            {
                Pow2 p = i;
                writer.WriteLine(p.FormatSymbolic());
            }
            Wf.EmittedFile(flow);
        }

        public void t_bits()
        {
            var claim = Checks().CheckEquatable;

            var b1 = Digital.bits(n1);
            claim.eq(b1.Length, 2);

            var b2 = Digital.bits(n2);
            claim.eq(b2.Length, 4);

            var b3 = Digital.bits(n3);
            claim.eq(b3.Length, 8);

            var b4 = Digital.bits(n4);
            claim.eq(b4.Length, 16);

            var b5 = Digital.bits(n5);
            claim.eq(b5.Length, 32);

            var b6 = Digital.bits(n6);
            var b7 = Digital.bits(n7);
            var b8 = Digital.bits(n8);


        }

    }
}
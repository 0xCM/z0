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
            Wf.EmittedFile(flow,64);
        }

        public ICheckEquatable CheckEq => new CheckEquatable();

        public void t_bits()
        {

            var Claim = CheckEq;

            var b1 = Digital.bits(n1);
            Claim.eq(b1.Length, 2);

            var b2 = Digital.bits(n2);
            Claim.eq(b2.Length, 4);

            var b3 = Digital.bits(n3);
            Claim.eq(b3.Length, 8);

            var b4 = Digital.bits(n4);
            Claim.eq(b4.Length, 16);

            var b5 = Digital.bits(n5);
            Claim.eq(b5.Length, 32);

            var b6 = Digital.bits(n6);
            var b7 = Digital.bits(n7);
            var b8 = Digital.bits(n8);
        }

        public void t_digit_parser()
        {
            var Claim = CheckEq;
            ReadOnlySpan<char> input = "0123456789ABCDEF";
            var count = input.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(input,i);
                DigitParser.digit(@base16, c, out var d);
                var s = Digital.symbol(UpperCase, d);
                Claim.eq((char)s, c);
            }
        }
    }
}
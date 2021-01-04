//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public class t_hex : t_symbolic<t_hex>
    {
        public void hexdigits_define()
        {
            byte x0 = 0x3C;
            var x0c = Hex.chars(x0);
            Claim.eq(2,x0c.Length);
            Claim.eq(Hex.hexchar(x0,Pos0), x0c[Pos0]);
            Claim.eq(Hex.hexchar(x0,Pos1), x0c[1]);

            ushort x1 = 0x4A3C;
            var x1c = Hex.chars(x1);
            Claim.eq(4,x1c.Length);
            Claim.eq(Hex.hexchar(x1,Pos0), x1c[Pos0]);
            Claim.eq(Hex.hexchar(x1,1), x1c[1]);
            Claim.eq(Hex.hexchar(x1,2), x1c[2]);
            Claim.eq(Hex.hexchar(x1,3), x1c[3]);

            uint x2 = 0x10F74A3C;
            var x2c = Hex.chars(x2);
            Claim.eq(8,x2c.Length);
            Claim.eq(Hex.hexchar(x2,Pos0), x2c[Pos0]);
            Claim.eq(Hex.hexchar(x2,1), x2c[1]);
            Claim.eq(Hex.hexchar(x2,2), x2c[2]);
            Claim.eq(Hex.hexchar(x2,3), x2c[3]);
            Claim.eq(Hex.hexchar(x2,4), x2c[4]);
            Claim.eq(Hex.hexchar(x2,5), x2c[5]);
            Claim.eq(Hex.hexchar(x2,6), x2c[6]);
            Claim.eq(Hex.hexchar(x2,7), x2c[7]);

            ulong x3 = 0x3383107810F74A3C;
            var x3c = Hex.chars(x3);
            Claim.eq(16,x3c.Length);
            Claim.eq(Hex.hexchar(x3,0), x3c[0]);
            Claim.eq(Hex.hexchar(x3,1), x3c[1]);
            Claim.eq(Hex.hexchar(x3,2), x3c[2]);
            Claim.eq(Hex.hexchar(x3,3), x3c[3]);
            Claim.eq(Hex.hexchar(x3,4), x3c[4]);
            Claim.eq(Hex.hexchar(x3,5), x3c[5]);
            Claim.eq(Hex.hexchar(x3,6), x3c[6]);
            Claim.eq(Hex.hexchar(x3,7), x3c[7]);
            Claim.eq(Hex.hexchar(x3,8), x3c[8]);
            Claim.eq(Hex.hexchar(x3,9), x3c[9]);
            Claim.eq(Hex.hexchar(x3,10), x3c[10]);
            Claim.eq(Hex.hexchar(x3,11), x3c[11]);
            Claim.eq(Hex.hexchar(x3,12), x3c[12]);
            Claim.eq(Hex.hexchar(x3,13), x3c[13]);
            Claim.eq(Hex.hexchar(x3,14), x3c[14]);
            Claim.eq(Hex.hexchar(x3,15), x3c[15]);
        }

        public void hexdigits_parse()
        {
            var parser = HexParsers.bytes();
            Claim.eq((byte)0, parser.Parse('0').Value);
            Claim.eq((byte)1, parser.Parse('1').Value);
            Claim.eq((byte)2, parser.Parse('2').Value);
            Claim.eq((byte)3, parser.Parse('3').Value);
            Claim.eq((byte)4, parser.Parse('4').Value);
            Claim.eq((byte)5, parser.Parse('5').Value);
            Claim.eq((byte)6, parser.Parse('6').Value);
            Claim.eq((byte)7, parser.Parse('7').Value);
            Claim.eq((byte)8, parser.Parse('8').Value);
            Claim.eq((byte)9, parser.Parse('9').Value);
            Claim.eq((byte)10, parser.Parse('A').Value);
            Claim.eq((byte)11, parser.Parse('B').Value);
            Claim.eq((byte)12, parser.Parse('C').Value);
            Claim.eq((byte)13, parser.Parse('D').Value);
            Claim.eq((byte)14, parser.Parse('E').Value);
            Claim.eq((byte)15, parser.Parse('F').Value);
        }
    }
}
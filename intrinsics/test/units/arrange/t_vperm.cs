//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vperm : t_vinx<t_vperm>
    {


        // [0 1 2 3 | 4 5 6 7 | 8 9 A B | C D E F] 
        //

        // public void bitfield_outline()
        // {
        //     var spec = BitField.specify((0,3),(4,6),(7,8),(9,9),(10,14),(15,17),(18,20));  
        //     var data = 0b100_101_11010_1_11_110_0111ul;          
        //     var bf = BitField.init(data,spec);

        //     Claim.eq(7,spec.FieldCount);

        //     var expect = new long[]{0b0111,0b110,0b11,0b1,0b11010,0b101,0b100};
        //     for(byte i=0; i < spec.FieldCount; i++)
        //         Claim.eq(bf[i], expect[i]);
        // }



        public void perm_symbols()
        {            
            Claim.eq($"{Perm4L.ABDC}", Perm4L.ABDC.Format());
            Claim.eq($"{Perm4L.DCBA}", Perm4L.DCBA.Format());           
            Claim.eq($"ABCDEFGH", Perm8L.Identity.Format());   
            Claim.eq($"HGFEDCBA", Perm8L.Reversed.Format());  
            Claim.eq($"0123456789ABCDEF", Perm16L.Identity.Format());
                    
        }

        public void perm4_digits()
        {
            const byte A = 0b00;
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var dABCD = Perm4L.ABCD.ToDigits();
            Claim.numeq(NatSpan.parts(n4, A, B, C, D), dABCD);

            var dDCBA = Perm4L.DCBA.ToDigits();
            Claim.numeq(NatSpan.parts(n4, D, C, B, A), dDCBA);

            var dACBD = Perm4L.ACBD.ToDigits();
            Claim.numeq(NatSpan.parts(n4, A, C, B, D), dACBD);

            var dCBDA = Perm4L.CBDA.ToDigits();
            Claim.numeq(NatSpan.parts(n4, C, B, D, A), dCBDA);
        }

        public void vpermlo_4x16_outline()
        {
            const byte A = 0b00;        
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var x = vpattern.vincrements<ushort>(n128);
            var xs = x.ToSpan();
            Claim.eq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = dinx.vpermlo4x16(x, Perm4L.ABCD);
            Claim.eq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = dinx.vpermlo4x16(x, Perm4L.DCBA);
            Claim.eq(xDCBA, Vector128.Create(xs[D], xs[C], xs[B], xs[A], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xACBD = dinx.vpermlo4x16(x, Perm4L.ACBD);
            Claim.eq(xACBD, Vector128.Create(xs[A], xs[C], xs[B], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            Claim.eq(dinx.vpermlo4x16(CpuVector.vparts(n128, 0,1,2,3,6,7,8,9), Perm4L.ADCB), CpuVector.vparts(n128, 0,3,2,1,6,7,8,9));           
        }

        public void vpermhi_4x16_outline()
        {
            const byte A = 0b00;            
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var x = vpattern.vincrements<ushort>(n128);
            var xs = x.ToSpan();
            Claim.eq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A+4], xs[B+ 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = dinx.vpermhi4x16(x, Perm4L.ABCD);
            Claim.eq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = dinx.vpermhi4x16(x, Perm4L.DCBA);
            Claim.eq(xDCBA, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[D + 4], xs[C + 4], xs[B + 4], xs[A + 4]));

            var xACBD = dinx.vpermhi4x16(x, Perm4L.ACBD);
            Claim.eq(xACBD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[C + 4], xs[B + 4], xs[D + 4]));            

            Claim.eq(dinx.vpermhi4x16(CpuVector.vparts(n128, 0,1,2,3,6,7,8,9), Perm4L.ADCB), CpuVector.vparts(n128,0,1,2,3,6,9,8,7));

        }

        public void vperm4x32_128x32u_outline()
        {
            var n = n128;

            var u = vpattern.vincrements<uint>(n);
            Claim.eq(CpuVector.vparts(n,0,1,2,3), u);

            var v = vpattern.decrements<uint>(n);
            Claim.eq(CpuVector.vparts(n,3,2,1,0),v);

            Claim.eq(v, dinx.vperm4x32(u, Perm4L.DCBA));
            Claim.eq(u, dinx.vperm4x32(v, Perm4L.DCBA));
        }

        public void vperm_4x16_outline()
        {
            var n = n128;
            var x = CpuVector.vparts(n,0,1,2,3,4,5,6,7);
                        
            var a0 = dinx.vpermlo4x16(x, Perm4L.DCBA);
            var a1 = CpuVector.vparts(n,3,2,1,0,4,5,6,7);
            Claim.eq(a0,a1);

            var b0 = dinx.vpermhi4x16(x, Perm4L.DCBA);
            var b1 = CpuVector.vparts(n,0,1,2,3,7,6,5,4);
            Claim.eq(b0,b1);

            var c0 = dinx.vperm4x16(x,Perm4L.DCBA,Perm4L.DCBA);
            var c1 = CpuVector.vparts(n,3,2,1,0,7,6,5,4);
            Claim.eq(c0,c1);

            var d0 = dinx.vpermlo4x16(x, Perm4L.BADC);
            var d1 = CpuVector.vparts(n,1,0,3,2,4,5,6,7);            
            Claim.eq(d0,d1);

            var e0 = dinx.vpermhi4x16(x, Perm4L.BADC);
            var e1 = CpuVector.vparts(n,0,1,2,3,5,4,7,6);
            Claim.eq(e0,e1);

            var f0 = dinx.vperm4x16(x, Perm4L.BADC, Perm4L.BADC);
            var f1 = CpuVector.vparts(n,1,0,3,2,5,4,7,6);
            Claim.eq(f0,f1);
        }

        public void vperm_4x64_outline()
        {
         
            var n = n256;
            var x = CpuVector.vparts(n,0,1,2,3);
            
            Claim.eq(CpuVector.vparts(n,0,1,2,3), dinx.vperm4x64(x, Perm4L.ABCD));
            Claim.eq(CpuVector.vparts(n,0,1,3,2), dinx.vperm4x64(x, Perm4L.ABDC));
            Claim.eq(CpuVector.vparts(n,0,2,1,3), dinx.vperm4x64(x, Perm4L.ACBD));
            Claim.eq(CpuVector.vparts(n,0,2,3,1), dinx.vperm4x64(x, Perm4L.ACDB));
            Claim.eq(CpuVector.vparts(n,0,3,1,2), dinx.vperm4x64(x, Perm4L.ADBC));
            Claim.eq(CpuVector.vparts(n,0,3,2,1), dinx.vperm4x64(x, Perm4L.ADCB));
            
            Claim.eq(CpuVector.vparts(n,1,0,2,3), dinx.vperm4x64(x, Perm4L.BACD));
            Claim.eq(CpuVector.vparts(n,1,0,3,2), dinx.vperm4x64(x, Perm4L.BADC));
            Claim.eq(CpuVector.vparts(n,1,2,0,3), dinx.vperm4x64(x, Perm4L.BCAD));
            Claim.eq(CpuVector.vparts(n,1,2,3,0), dinx.vperm4x64(x, Perm4L.BCDA));
            Claim.eq(CpuVector.vparts(n,1,3,0,2), dinx.vperm4x64(x, Perm4L.BDAC));
            Claim.eq(CpuVector.vparts(n,1,3,2,0), dinx.vperm4x64(x, Perm4L.BDCA));
        }

        public void perm4_symbols()
        {
            perm4_symbol_check(Perm4L.ABCD, A,B,C,D);
            perm4_symbol_check(Perm4L.ABDC, A,B,D,C);
            perm4_symbol_check(Perm4L.ACBD, A,C,B,D);
            perm4_symbol_check(Perm4L.ACDB, A,C,D,B);
            perm4_symbol_check(Perm4L.ADBC, A,D,B,C);
            perm4_symbol_check(Perm4L.ADCB, A,D,C,B);

            perm4_symbol_check(Perm4L.BACD, B,A,C,D);
            perm4_symbol_check(Perm4L.BADC, B,A,D,C);
            perm4_symbol_check(Perm4L.BCAD, B,C,A,D);
            perm4_symbol_check(Perm4L.BCDA, B,C,D,A);
            perm4_symbol_check(Perm4L.BDAC, B,D,A,C);
            perm4_symbol_check(Perm4L.BDCA, B,D,C,A);

        }

        [MethodImpl(NotInline)]
        static Vector128<T> vswapspec<T>(N128 n, params Swap[] swaps)
            where T : unmanaged  
        {
            var src = vpattern.vincrements<T>(n).ToSpan();
            var dst = src.Swap(swaps);
            return CpuVector.vload(n, in head(src));
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vswap(Vector128<byte> src, params Swap[] swaps)
            => dinx.vshuf16x8(src, vswapspec<byte>(n128, swaps));

        public void perm_swaps()
        {            
            
            var src = vpattern.vincrements<byte>(n128);

            Swap s = (0,1);
            var x1 = vswap(src, s);
            var x2 = vswap(x1, s);
            Claim.eq(x2, src);

            //Shuffle the first element all the way through to the last element
            var chain = Swap.Chain((0,1), 15);
            var x3 = vswap(src, chain).ToSpan();
            Claim.eq(x3[15],(byte)0);            
        }

        public void perm4_symbols_random()
        {
            var perms = Random.EnumValues(A, B, C, D);
            var all = Enums.literals<Perm4L>().ToSet();
            for(var i=0; i<RepCount; i++)
            {
                var perm = perms.First();
                Claim.contains(all,perm);
                var symbols = permute.literals(perm);
                Claim.eq(4, symbols.Length);
            }
        }

        void perm4x64_mapformat()
        {
            var pmaps = permute.mappings(n4);
            iter(pmaps, m => Trace(m.perm.ToString(), m.format));
        }

        public void vperm_2x128_outline()
        {
            var n = n256;
            var x = CpuVector.vparts(n, 0, 1, 2, 3);
            var y = CpuVector.vparts(n, 4, 5, 6, 7);

            Claim.eq(CpuVector.vparts(n, 0, 1, 4, 5), ginx.vperm2x128(x,y, Perm2x4.AC));
            Claim.eq(CpuVector.vparts(n, 4, 5, 0, 1), ginx.vperm2x128(x,y, Perm2x4.CA));

            Claim.eq(CpuVector.vparts(n, 0, 1, 6, 7), ginx.vperm2x128(x,y, Perm2x4.AD));
            Claim.eq(CpuVector.vparts(n, 6, 7, 0, 1), ginx.vperm2x128(x,y, Perm2x4.DA));

            Claim.eq(CpuVector.vparts(n, 2, 3, 4, 5), ginx.vperm2x128(x,y, Perm2x4.BC));
            Claim.eq(CpuVector.vparts(n, 4, 5, 2, 3), ginx.vperm2x128(x,y, Perm2x4.CB));

            Claim.eq(CpuVector.vparts(n, 2, 3, 6, 7), ginx.vperm2x128(x,y, Perm2x4.BD));
            Claim.eq(CpuVector.vparts(n, 6, 7, 2, 3), ginx.vperm2x128(x,y, Perm2x4.DB));
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
        {
            Vector256<byte> y = default;
            y = dinx.vinsert(dinx.vhi(x), y, 0);
            y = dinx.vinsert(dinx.vlo(x), y, 1);
            return y;
        }

        public void swaphl_2x128()
        {
            for(var i=0; i < RepCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = vswaphl(x);
                var z = dinx.vswaphl(x);
                Claim.eq(y,z);
            }
        }

        public void vperm4x64_256x64u_randomized()
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = vpattern.vincrements<ulong>(n256);
                var x = dinx.vperm4x64(src, Perm4L.BADC);
                var srcs = src.ToSpan();
                var y = Vector256.Create(srcs[1], srcs[0], srcs[3], srcs[2]);
                Claim.eq(x,y);
            }
        }

        public void vperm_256u8_outline()
        {
            var x = vpattern.vincrements<byte>(n256);
            var y = vpattern.decrements<byte>(n256);
            var z = dinx.vreverse(dinx.vshuf32x8(x,y));
            Claim.eq(x,z);
        }

        public void vperm4_reverse()
        {
            const Perm4L  p = Perm4L.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.scalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = permute.assemble(Perm4L.D, Perm4L.C, Perm4L.B, Perm4L.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = CpuVector.vparts(0,1,2,3);
            var vExpect = CpuVector.vparts(3,2,1,0);
            var vActual = dinx.vperm4x32(vIn,p);
            Claim.eq(vExpect, vActual);                                
        }        

        void perm4_symbol_check(Perm4L perm, params Perm4L[] expect)
        {
            Claim.eq(4, expect.Length);
            var symbol = default(Perm4L);
            for(var i=0; i<expect.Length; i++)
            {
                Claim.yea(permute.literal(perm, i, out symbol));
                Claim.eq(expect[i], symbol);
            }

        }

        const Perm4L A = Perm4L.A;

        const Perm4L B = Perm4L.B;

        const Perm4L C = Perm4L.C;

        const Perm4L D = Perm4L.D;
    }
}
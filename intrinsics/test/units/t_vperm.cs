//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vperm : t_vinx<t_vperm>
    {
        public void vperm_4x16()
        {
            var n = n128;
            var x = vbuild.parts(n,0,1,2,3,4,5,6,7);
            
            
            var a0 = dinx.vpermlo4x16(x, Perm4.DCBA);
            var a1 = vbuild.parts(n,3,2,1,0,4,5,6,7);
            Claim.eq(a0,a1);

            var b0 = dinx.vpermhi4x16(x, Perm4.DCBA);
            var b1 = vbuild.parts(n,0,1,2,3,7,6,5,4);
            Claim.eq(b0,b1);

            var c0 = dinx.vperm4x16(x,Perm4.DCBA,Perm4.DCBA);
            var c1 = vbuild.parts(n,3,2,1,0,7,6,5,4);
            Claim.eq(c0,c1);

            var d0 = dinx.vpermlo4x16(x, Perm4.BADC);
            var d1 = vbuild.parts(n,1,0,3,2,4,5,6,7);            
            Claim.eq(d0,d1);

            var e0 = dinx.vpermhi4x16(x, Perm4.BADC);
            var e1 = vbuild.parts(n,0,1,2,3,5,4,7,6);
            Claim.eq(e0,e1);

            var f0 = dinx.vperm4x16(x, Perm4.BADC, Perm4.BADC);
            var f1 = vbuild.parts(n,1,0,3,2,5,4,7,6);
            Claim.eq(f0,f1);
        }

        public void vperm_4x64()
        {
         
            var n = n256;
            var x = vbuild.parts(n,0,1,2,3);
            
            Claim.eq(vbuild.parts(n,0,1,2,3), dinx.vperm4x64(x, Perm4.ABCD));
            Claim.eq(vbuild.parts(n,0,1,3,2), dinx.vperm4x64(x, Perm4.ABDC));
            Claim.eq(vbuild.parts(n,0,2,1,3), dinx.vperm4x64(x, Perm4.ACBD));
            Claim.eq(vbuild.parts(n,0,2,3,1), dinx.vperm4x64(x, Perm4.ACDB));
            Claim.eq(vbuild.parts(n,0,3,1,2), dinx.vperm4x64(x, Perm4.ADBC));
            Claim.eq(vbuild.parts(n,0,3,2,1), dinx.vperm4x64(x, Perm4.ADCB));
            
            Claim.eq(vbuild.parts(n,1,0,2,3), dinx.vperm4x64(x, Perm4.BACD));
            Claim.eq(vbuild.parts(n,1,0,3,2), dinx.vperm4x64(x, Perm4.BADC));
            Claim.eq(vbuild.parts(n,1,2,0,3), dinx.vperm4x64(x, Perm4.BCAD));
            Claim.eq(vbuild.parts(n,1,2,3,0), dinx.vperm4x64(x, Perm4.BCDA));
            Claim.eq(vbuild.parts(n,1,3,0,2), dinx.vperm4x64(x, Perm4.BDAC));
            Claim.eq(vbuild.parts(n,1,3,2,0), dinx.vperm4x64(x, Perm4.BDCA));
        }

        public void perm4_symbols()
        {
            perm4_symbol_check(Perm4.ABCD, A,B,C,D);
            perm4_symbol_check(Perm4.ABDC, A,B,D,C);
            perm4_symbol_check(Perm4.ACBD, A,C,B,D);
            perm4_symbol_check(Perm4.ACDB, A,C,D,B);
            perm4_symbol_check(Perm4.ADBC, A,D,B,C);
            perm4_symbol_check(Perm4.ADCB, A,D,C,B);

            perm4_symbol_check(Perm4.BACD, B,A,C,D);
            perm4_symbol_check(Perm4.BADC, B,A,D,C);
            perm4_symbol_check(Perm4.BCAD, B,C,A,D);
            perm4_symbol_check(Perm4.BCDA, B,C,D,A);
            perm4_symbol_check(Perm4.BDAC, B,D,A,C);
            perm4_symbol_check(Perm4.BDCA, B,D,C,A);

        }

        public void perm4_symbols_random()
        {
            var perms = Random.EnumValues(A, B, C, D);
            var all = evalues<Perm4>().ToSet();
            for(var i=0; i<SampleSize; i++)
            {
                var perm = perms.First();
                Claim.contains(all,perm);
                var symbols = Perm.literals(perm);
                Claim.eq(4, symbols.Length);
            }
        }

        void perm4x64_mapformat()
        {
            var pmaps = Perm.mappings(n4);
            iter(pmaps, m => Trace(m.perm.ToString(), m.format));
        }

        public void vperm_2x128()
        {
            var n = n256;
            var x = vbuild.parts(n, 0, 1, 2, 3);
            var y = vbuild.parts(n, 4, 5, 6, 7);

            Claim.eq(vbuild.parts(n, 0, 1, 4, 5), ginx.vperm2x128(x,y, Perm2x4.AC));
            Claim.eq(vbuild.parts(n, 4, 5, 0, 1), ginx.vperm2x128(x,y, Perm2x4.CA));

            Claim.eq(vbuild.parts(n, 0, 1, 6, 7), ginx.vperm2x128(x,y, Perm2x4.AD));
            Claim.eq(vbuild.parts(n, 6, 7, 0, 1), ginx.vperm2x128(x,y, Perm2x4.DA));

            Claim.eq(vbuild.parts(n, 2, 3, 4, 5), ginx.vperm2x128(x,y, Perm2x4.BC));
            Claim.eq(vbuild.parts(n, 4, 5, 2, 3), ginx.vperm2x128(x,y, Perm2x4.CB));

            Claim.eq(vbuild.parts(n, 2, 3, 6, 7), ginx.vperm2x128(x,y, Perm2x4.BD));
            Claim.eq(vbuild.parts(n, 6, 7, 2, 3), ginx.vperm2x128(x,y, Perm2x4.DB));
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
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = vswaphl(x);
                var z = dinx.vswaphl(x);
                Claim.eq(y,z);
            }
        }

        public void perm4x64_256x64u_randomized()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = ginx.vincrements<ulong>(n256);
                var x = dinx.vperm4x64(src, Perm4.BADC);
                var srcs = src.ToSpan();
                var y = Vector256.Create(srcs[1], srcs[0], srcs[3], srcs[2]);
                Claim.eq(x,y);
            }
        }

        public void perm256u8()
        {
            var x = ginx.vincrements<byte>(n256);
            var y = ginx.vdecrements<byte>(n256);
            var z = dinx.vreverse(dinx.vshuf32x8(x,y));
            Claim.eq(x,z);
        }

        public void perm4_reverse_check()
        {
            const Perm4  p = Perm4.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.scalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = Perm.assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = vbuild.parts(0,1,2,3);
            var vExpect = vbuild.parts(3,2,1,0);
            var vActual = dinx.vperm4x32(vIn,p);
            Claim.eq(vExpect, vActual);                                
        }        

        void perm4_symbol_check(Perm4 perm, params Perm4[] expect)
        {
            Claim.eq(4, expect.Length);
            var symbol = default(Perm4);
            for(var i=0; i<expect.Length; i++)
            {
                Claim.yea(Perm.literal(perm, i, out symbol));
                Claim.eq(expect[i], symbol);
            }

        }

        const Perm4 A = Perm4.A;

        const Perm4 B = Perm4.B;

        const Perm4 C = Perm4.C;

        const Perm4 D = Perm4.D;
    }
}
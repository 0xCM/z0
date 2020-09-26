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

    using static Konst;
    using static z;

    public class t_vperm : t_permute<t_vperm>
    {
        /// <summary>
        /// Asserts content equality for two natural spans of coincident length
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public void numeq<N,T>(NatSpan<N,T> lhs, NatSpan<N,T> rhs)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ClaimNumeric.Eq(lhs.Edit,rhs.Edit);

        /// <summary>
        /// Asserts content equality for two tabular spans of coincident dimension
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public void numeq<M,N,T>(TableSpan<M,N,T> lhs, TableSpan<M,N,T> rhs)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => ClaimNumeric.Eq(lhs.Data, rhs.Data);

        public void perm_symbols()
        {
            Claim.eq($"{Perm4L.ABDC}", Perm4L.ABDC.Format());
            Claim.eq($"{Perm4L.DCBA}", Perm4L.DCBA.Format());
            Claim.eq($"ABCDEFGH", PermLits.Perm8Identity.Format());
            Claim.eq($"HGFEDCBA", PermLits.Perm8Reversed.Format());
            Claim.eq($"0123456789ABCDEF", PermLits.Perm16Identity.Format());
        }

        public void perm4_digits()
        {
            const byte A = 0b00;
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var dABCD = Perm4L.ABCD.ToDigits();
            ClaimNumeric.eq(NatSpan.parts(n4, A, B, C, D), dABCD);

            var dDCBA = Perm4L.DCBA.ToDigits();
            ClaimNumeric.eq(NatSpan.parts(n4, D, C, B, A), dDCBA);

            var dACBD = Perm4L.ACBD.ToDigits();
            ClaimNumeric.eq(NatSpan.parts(n4, A, C, B, D), dACBD);

            var dCBDA = Perm4L.CBDA.ToDigits();
            ClaimNumeric.eq(NatSpan.parts(n4, C, B, D, A), dCBDA);
        }

        public void vpermlo_4x16_outline()
        {
            const byte A = 0b00;
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var x = V0.vinc<ushort>(n128);
            var xs = x.ToSpan();
            Claim.veq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = z.vpermlo4x16(x, Perm4L.ABCD);
            Claim.veq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = z.vpermlo4x16(x, Perm4L.DCBA);
            Claim.veq(xDCBA, Vector128.Create(xs[D], xs[C], xs[B], xs[A], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xACBD = z.vpermlo4x16(x, Perm4L.ACBD);
            Claim.veq(xACBD, Vector128.Create(xs[A], xs[C], xs[B], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            Claim.veq(z.vpermlo4x16(vparts(n128, 0,1,2,3,6,7,8,9), Perm4L.ADCB), vparts(n128, 0,3,2,1,6,7,8,9));
        }

        public void vpermhi_4x16_outline()
        {
            const byte A = 0b00;
            const byte B = 0b01;
            const byte C = 0b10;
            const byte D = 0b11;

            var x = V0.vinc<ushort>(n128);
            var xs = x.ToSpan();
            Claim.veq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A+4], xs[B+ 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = z.vpermhi4x16(x, Perm4L.ABCD);
            Claim.veq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = z.vpermhi4x16(x, Perm4L.DCBA);
            Claim.veq(xDCBA, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[D + 4], xs[C + 4], xs[B + 4], xs[A + 4]));

            var xACBD = z.vpermhi4x16(x, Perm4L.ACBD);
            Claim.veq(xACBD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[C + 4], xs[B + 4], xs[D + 4]));

            Claim.veq(z.vpermhi4x16(vparts(n128, 0,1,2,3,6,7,8,9), Perm4L.ADCB), vparts(n128,0,1,2,3,6,9,8,7));

        }

        public void vperm4x32_128x32u_outline()
        {
            var n = n128;

            var u = V0.vinc<uint>(n);
            Claim.veq(vparts(n,0,1,2,3), u);

            var v = V0.vdec<uint>(n);
            Claim.veq(vparts(n,3,2,1,0),v);

            Claim.veq(v, z.vperm4x32(u, Perm4L.DCBA));
            Claim.veq(u, z.vperm4x32(v, Perm4L.DCBA));
        }

        public void vperm_4x16_outline()
        {
            var w = W128.W;
            var x = vparts(w,0,1,2,3,4,5,6,7);

            var a0 = vpermlo4x16(x, Perm4L.DCBA);
            var a1 = vparts(w,3,2,1,0,4,5,6,7);
            Claim.veq(a0,a1);

            var b0 = vpermhi4x16(x, Perm4L.DCBA);
            var b1 = vparts(w,0,1,2,3,7,6,5,4);
            Claim.veq(b0,b1);

            var c0 = vperm4x16(x,Perm4L.DCBA,Perm4L.DCBA);
            var c1 = vparts(w,3,2,1,0,7,6,5,4);
            Claim.veq(c0,c1);

            var d0 = vpermlo4x16(x, Perm4L.BADC);
            var d1 = vparts(w,1,0,3,2,4,5,6,7);
            Claim.veq(d0,d1);

            var e0 = vpermhi4x16(x, Perm4L.BADC);
            var e1 = vparts(w,0,1,2,3,5,4,7,6);
            Claim.veq(e0,e1);

            var f0 = z.vperm4x16(x, Perm4L.BADC, Perm4L.BADC);
            var f1 = vparts(w,1,0,3,2,5,4,7,6);
            Claim.veq(f0,f1);
        }

        public void vperm_4x64_outline()
        {

            var n = n256;
            var x = vparts(n,0,1,2,3);

            Claim.veq(vparts(n,0,1,2,3), vperm4x64(x, Perm4L.ABCD));
            Claim.veq(vparts(n,0,1,3,2), vperm4x64(x, Perm4L.ABDC));
            Claim.veq(vparts(n,0,2,1,3), vperm4x64(x, Perm4L.ACBD));
            Claim.veq(vparts(n,0,2,3,1), vperm4x64(x, Perm4L.ACDB));
            Claim.veq(vparts(n,0,3,1,2), vperm4x64(x, Perm4L.ADBC));
            Claim.veq(vparts(n,0,3,2,1), vperm4x64(x, Perm4L.ADCB));

            Claim.veq(vparts(n,1,0,2,3), vperm4x64(x, Perm4L.BACD));
            Claim.veq(vparts(n,1,0,3,2), vperm4x64(x, Perm4L.BADC));
            Claim.veq(vparts(n,1,2,0,3), vperm4x64(x, Perm4L.BCAD));
            Claim.veq(vparts(n,1,2,3,0), vperm4x64(x, Perm4L.BCDA));
            Claim.veq(vparts(n,1,3,0,2), vperm4x64(x, Perm4L.BDAC));
            Claim.veq(vparts(n,1,3,2,0), vperm4x64(x, Perm4L.BDCA));
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

        static Vector128<T> vswapspec<T>(N128 n, params Swap[] swaps)
            where T : unmanaged
        {
            var src = z.vinc<T>(n).ToSpan();
            var dst = src.Swap(swaps);
            return Vectors.vload(n, in z.first(src));
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vswap(Vector128<byte> src, params Swap[] swaps)
            => z.vshuf16x8(src, vswapspec<byte>(n128, swaps));

        public void perm_swaps()
        {

            var src = z.vinc<byte>(n128);

            Swap s = (0,1);
            var x1 = vswap(src, s);
            var x2 = vswap(x1, s);
            Claim.veq(x2, src);

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
                var symbols = Symbolic.literals(perm);
                Claim.eq(4, symbols.Length);
            }
        }

        void perm4x64_mapformat()
        {
            var pmaps = Permute.symbols(n4);
            Root.iter(pmaps, m => Trace(m.perm.ToString(), m.format));
        }

        public void vperm_2x128_outline()
        {
            var n = n256;
            var x = vparts(n, 0, 1, 2, 3);
            var y = vparts(n, 4, 5, 6, 7);

            Claim.veq(vparts(n, 0, 1, 4, 5), gvec.vperm2x128(x,y, Perm2x4.AC));
            Claim.veq(vparts(n, 4, 5, 0, 1), gvec.vperm2x128(x,y, Perm2x4.CA));

            Claim.veq(vparts(n, 0, 1, 6, 7), gvec.vperm2x128(x,y, Perm2x4.AD));
            Claim.veq(vparts(n, 6, 7, 0, 1), gvec.vperm2x128(x,y, Perm2x4.DA));

            Claim.veq(vparts(n, 2, 3, 4, 5), gvec.vperm2x128(x,y, Perm2x4.BC));
            Claim.veq(vparts(n, 4, 5, 2, 3), gvec.vperm2x128(x,y, Perm2x4.CB));

            Claim.veq(vparts(n, 2, 3, 6, 7), gvec.vperm2x128(x,y, Perm2x4.BD));
            Claim.veq(vparts(n, 6, 7, 2, 3), gvec.vperm2x128(x,y, Perm2x4.DB));
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
        {
            Vector256<byte> y = default;
            y = z.vinsert(vhi(x), y, BitState.Off);
            y = z.vinsert(vlo(x), y, BitState.On);
            return y;
        }

        public void swaphl_2x128()
        {
            for(var i=0; i < RepCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = vswaphl(x);
                var _z = z.vswaphl(x);
                Claim.veq(y,_z);
            }
        }

        public void vperm4x64_256x64u_randomized()
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = z.vinc<ulong>(n256);
                var x = z.vperm4x64(src, Perm4L.BADC);
                var srcs = src.ToSpan();
                var y = Vector256.Create(srcs[1], srcs[0], srcs[3], srcs[2]);
                Claim.veq(x,y);
            }
        }

        public void vperm_256u8_outline()
        {
            var a = V0.vinc<byte>(n256);
            var b = VKonst.vdecrements<byte>(n256);
            var c = z.vreverse(z.vshuf32x8(a,b));
            Claim.veq(a,c);
        }

        public void vperm4_reverse()
        {
            const Perm4L  p = Perm4L.DCBA;
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.scalar((byte)p);
            Claim.eq(pbs_expect, pbs_actual);

            var p_assembled = Permutary.assemble(Perm4L.D, Perm4L.C, Perm4L.B, Perm4L.A);
            Claim.Eq(p, p_assembled);

            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = vparts(w128, 0,1,2,3);
            var vExpect = vparts(w128, 3,2,1,0);
            var vActual = vperm4x32(vIn,p);
            Claim.veq(vExpect, vActual);
        }

        void perm4_symbol_check(Perm4L perm, params Perm4L[] expect)
        {
            Claim.eq(4, expect.Length);
            var symbol = default(Perm4L);
            for(var i=0; i<expect.Length; i++)
            {
                Claim.Require(Symbolic.literal(perm, i, out symbol));
                Claim.Eq(expect[i], symbol);
            }
        }

        const Perm4L A = Perm4L.A;

        const Perm4L B = Perm4L.B;

        const Perm4L C = Perm4L.C;

        const Perm4L D = Perm4L.D;
    }
}
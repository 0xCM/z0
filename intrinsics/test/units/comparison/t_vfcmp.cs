//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Core;
    
    public class t_vfcmp : t_vinx<t_vfcmp>
    {                    
        public void eq_128xf64()
            => cmp_128x64_check(FpCmpMode.EQ_OQ);

        public void neq_128xf64()
            => cmp_128x64_check(FpCmpMode.NEQ_OQ);

        public void lt_128xf64()
            => cmp_128x64_check(FpCmpMode.LT_OQ);

        public void lteq_128xf64()
            => cmp_128x64_check(FpCmpMode.LE_OQ);

        public void nlt_128xf64()
            => cmp_128x64_check(FpCmpMode.LE_OQ);

        public void nlteq_128xf64()
            => cmp_128x64_check(FpCmpMode.NLE_UQ);

        public void gt128_f64()
            => cmp_128x64_check(FpCmpMode.GT_OQ);

        public void gteq128_f64()
            => cmp_128x64_check(FpCmpMode.GE_OQ);

        public void ngt128_f64()
            => cmp_128x64_check(FpCmpMode.NGT_UQ);

        public void ngteq128_f64()
            => cmp_128x64_check(FpCmpMode.NGE_UQ);

        public void eq_256xf64()
            => cmp_256x64_check(FpCmpMode.EQ_OQ);

        public void neq_256xf64()
            => cmp_256x64_check(FpCmpMode.NEQ_OQ);

        public void lt_256xf64()
            => cmp_256x64_check(FpCmpMode.LT_OQ);

        public void lteq_256xf64()
            => cmp_256x64_check(FpCmpMode.LE_OQ);

        public void nlt_256xf64()
            => cmp_256x64_check(FpCmpMode.LE_OQ);

        public void nlteq_256xf64()
            => cmp_256x64_check(FpCmpMode.NLE_UQ);

        public void gt_256xf64()
            => cmp_256x64_check(FpCmpMode.GT_OQ);

        public void gteq_256xf64()
            => cmp_256x64_check(FpCmpMode.GE_OQ);

        public void ngt_256xf64()
            => cmp_256x64_check(FpCmpMode.NGT_UQ);

        public void ngteq256_f64()
            => cmp_256x64_check(FpCmpMode.NGE_UQ);

        public void eq_256xf32()
            => cmp_256xf32_check(FpCmpMode.EQ_OQ);

        public void neq_256xf32()
            => cmp_256xf32_check(FpCmpMode.NEQ_OQ);

        public void lt_256xf32()
            => cmp_256xf32_check(FpCmpMode.LT_OQ);

        public void lteq_256xf32()
            => cmp_256xf32_check(FpCmpMode.LE_OQ);

        public void nlt_256xf32()
            => cmp_256xf32_check(FpCmpMode.LE_OQ);

        public void nlteq_256xf32()
            => cmp_256xf32_check(FpCmpMode.NLE_UQ);

        public void gt_256xf32()
            => cmp_256xf32_check(FpCmpMode.GT_OQ);

        public void gteq_256xf32()
            => cmp_256xf32_check(FpCmpMode.GE_OQ);

        public void ngt_256xf32()
            => cmp_256xf32_check(FpCmpMode.NGT_UQ);

        public void ngteq_256xf32()
            => cmp_256xf32_check(FpCmpMode.NGE_UQ);

        protected void cmp_128x64_check(FpCmpMode mode)
        {
            for(var i = 0; i<RepCount; i++)
            {
                var lhs = Random.CpuVector<double>(n128);
                var rhs = Random.CpuVector<double>(n128);

                Span<double> lDst = stackalloc double[2];
                lhs.StoreTo(lDst);

                Span<double> rDst = stackalloc double[2];
                rhs.StoreTo(rDst);

                var expect = fmath.fcmp(lDst, rDst, mode);
                var actual = vcmpf(lhs, rhs, mode);
                Claim.eq(expect,actual);
            }
        }

        protected void cmp_256xf32_check(FpCmpMode mode)
        {
            for(var i = 0; i<RepCount; i++)
            {
                var x = Random.CpuVector<float>(n256);
                var y = Random.CpuVector<float>(n256);

                Span<float> xDst = stackalloc float[8];
                x.StoreTo(xDst);

                Span<float> yDst = stackalloc float[8];
                y.StoreTo(yDst);

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }
        }

        protected void cmp_256x64_check(FpCmpMode mode)
        {
            for(var i = 0; i<RepCount; i++)
            {
                var x = Random.CpuVector<double>(n256);
                var y = Random.CpuVector<double>(n256);

                Span<double> xDst = stackalloc double[4];
                x.StoreTo(ref head(xDst));

                Span<double> yDst = stackalloc double[4];
                y.StoreTo(ref head(yDst));

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }
        }

        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector128<double> src)
            => array(src.GetElement(0).IsNaN(), src.GetElement(1).IsNaN());

        /// <summary>
        /// __m128d _mm_cmp_pd (__m128d a, __m128d b, const int imm8)VCMPPD xmm, xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline)]
        static bool[] vcmpf(Vector128<double> x, Vector128<double> y, FpCmpMode mode)
            => TestNaN(Compare(x, y, fpmode(mode)));

        [MethodImpl(Inline)]
        static bool[] cmpf(Vector256<float> x, Vector256<float> y, FpCmpMode mode)
        {
            Span<float> vresult = stackalloc float[8];
            Compare(x,y, fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[8];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            bits[4] = double.IsNaN(vresult[4]);
            bits[5] = double.IsNaN(vresult[5]);
            bits[6] = double.IsNaN(vresult[6]);
            bits[7] = double.IsNaN(vresult[7]);
            return bits;

        }

        [MethodImpl(Inline)]
        static bool[] cmpf(Vector256<double> x, Vector256<double> y, FpCmpMode mode)
        {
            Span<double> vresult = stackalloc double[4];
            Compare(x,y, fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[4];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            return bits;
        } 
    }
}
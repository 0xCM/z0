//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    using static zfunc;

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
            for(var i = 0; i<SampleSize; i++)
            {
                var lhs = Random.CpuVector<double>(n128);
                var rhs = Random.CpuVector<double>(n128);

                Span<double> lDst = stackalloc double[2];
                lhs.StoreTo(ref head(lDst));

                Span<double> rDst = stackalloc double[2];
                rhs.StoreTo(ref head(rDst));

                var expect = fmath.fcmp(lDst, rDst, mode);
                var actual = fpinx.vcmpf(lhs, rhs, mode);
                Claim.eq(expect,actual);
            }

        }

        protected void cmp_256xf32_check(FpCmpMode mode)
        {
            for(var i = 0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<float>(n256);
                var y = Random.CpuVector<float>(n256);

                Span<float> xDst = stackalloc float[8];
                x.StoreTo(ref head(xDst));

                Span<float> yDst = stackalloc float[8];
                y.StoreTo(ref head(yDst));

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = fpinx.cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }
        }

        protected void cmp_256x64_check(FpCmpMode mode)
        {
            for(var i = 0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<double>(n256);
                var y = Random.CpuVector<double>(n256);

                Span<double> xDst = stackalloc double[4];
                x.StoreTo(ref head(xDst));

                Span<double> yDst = stackalloc double[4];
                y.StoreTo(ref head(yDst));

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = fpinx.cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }
        }

    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    public class tvml_abs : UnitTest<tvml_abs>
    {
        public void vAbsF32()
        {
            var src = Random.VectorBlock<float>(Pow2.T08);
            var dst1 = src.Replicate();
            mkl.abs(src, ref dst1);
            var dst2 = src.Replicate();
            fspan.abs(src,dst2.Unblocked);
            Claim.require(dst1 == dst2);
        }

        public void vAbsF64()
        {
            var src = Random.VectorBlock<double>(Pow2.T08);
            var dst1 = src.Replicate();
            mkl.abs(src, ref dst1);
            var dst2 = src.Replicate();
            fspan.abs(src,dst2.Unblocked);
            Claim.require(dst1 == dst2);
        }
    }
}

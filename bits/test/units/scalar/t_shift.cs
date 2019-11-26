//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_shift : t_sb<t_shift>
    {
        public void sal_8i()
        {
            var src = Random.Array<sbyte>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<sbyte>()));            

            iter(SampleSize, i => Claim.eq((sbyte)(src[i] << offset[i]), gmath.sal(src[i], offset[i])));    
        }

        public void sar_8i()
        {
            var src = Random.Array<sbyte>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<sbyte>()));                
            iter(SampleSize, i => Claim.eq((sbyte)(src[i] >> offset[i]), gmath.sar(src[i], offset[i])));    
        }

        public void sal_32i()
        {
            var src = Random.Array<int>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<int>()));            
            iter(SampleSize, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));    
        }

        public void sar_32i()
        {
            var src = Random.Array<int>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<int>()));            
            iter(SampleSize, i => Claim.eq(src[i] >> offset[i], gmath.sar(src[i], offset[i])));
        }

        public void sal_64i()
        {
            var src = Random.Array<long>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<ulong>()));            

            iter(SampleSize, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));    
        }

        public void sar_64i()
        {
            var src = Random.Array<long>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)bitsize<long>()));            

            iter(SampleSize, i => Claim.eq(src[i] >> offset[i], gmath.sar(src[i], offset[i])));
        }

    }

}

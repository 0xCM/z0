//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_shift : t_sb<t_sb_shift>
    {
        public void bs_sar_8i_check()
            => bs_sar_check<sbyte>();

        public void bs_sar_8u_check()
            => bs_sar_check<byte>();
            
        public void bs_sar_16i_check()        
            => bs_sar_check<short>();            
        
        public void bs_sar_16u_check()        
            => bs_sar_check<ushort>();
        
        public void bs_sar_32i_check()        
            => bs_sar_check<int>();            
        
        public void bs_sar_32u_check()        
            => bs_sar_check<uint>();            
        
        public void bs_sar_64i_check()        
            => bs_sar_check<long>();           
    
        public void bs_sar_64u_check()        
            => bs_sar_check<ulong>();


        public void sb_sal_8i()
        {
            var src = Random.Array<sbyte>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<sbyte>()));            

            iter(SampleCount, i => Claim.eq((sbyte)(src[i] << offset[i]), gmath.sal(src[i], offset[i])));    
        }

        public void sb_sar_8i()
        {
            var src = Random.Array<sbyte>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<sbyte>()));                
            iter(SampleCount, i => Claim.eq((sbyte)(src[i] >> offset[i]), gmath.sar(src[i], offset[i])));    
        }

        public void sb_sal_32i()
        {
            var src = Random.Array<int>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<int>()));            
            iter(SampleCount, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));    
        }

        public void sb_sar_32i()
        {
            var src = Random.Array<int>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<int>()));            
            iter(SampleCount, i => Claim.eq(src[i] >> offset[i], gmath.sar(src[i], offset[i])));
        }

        public void sb_sal_64i()
        {
            var src = Random.Array<long>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<ulong>()));            

            iter(SampleCount, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));    
        }

        public void sb_sar_64i()
        {
            var src = Random.Array<long>(SampleCount);            
            var offset = Random.Array<int>(SampleCount, closed(0, (int)bitsize<long>()));            

            iter(SampleCount, i => Claim.eq(src[i] >> offset[i], gmath.sar(src[i], offset[i])));
        }

        protected void bs_sar_check<T>()
            where T : unmanaged
        {

            var signed = signedint<T>();
            BitSize bitsize = bitsize<T>();
            var bs10 = BitString.parse("1" + repeat('0', bitsize - 1).Concat());
            var x10 = bs10.TakeScalar<T>();
            var bs11 = BitString.parse("11" + repeat('0', bitsize - 2).Concat());
            var x11 = bs11.TakeScalar<T>();
            var bs01 = BitString.parse("01" + repeat('0', bitsize - 2).Concat());
            var x01 = bs01.TakeScalar<T>();
            var y = gmath.sar(x10, 1);
            if(signed)
                Claim.eq(x11, y);
            else
                Claim.eq(x01, y);

        }

    }

}

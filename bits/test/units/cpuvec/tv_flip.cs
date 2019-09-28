//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using D = BitwiseDelegates;

    public class t_vflip : UnitTest<t_vflip>
    {
        public void vflip_g128x8u_check()
        {
            vflip_128_check<byte>();
        }

        public void vflip_g128x8i_check()
        {
            vflip_128_check<sbyte>();
        }

        public void vflip_g128x16i_check()
        {
            vflip_128_check<short>();
        }

        public void vflip_g128x16u_check()
        {
            vflip_128_check<ushort>();
        }

        public void vflip_g128x32i_check()
        {
            
            vflip_128_check<int>();
        }

        public void vflip_g128x32u_check()
        {
            vflip_128_check<uint>();
        }
        
        public void vflip_g256x8u_check()
        {
            vflip_256_check<byte>();
        }

        public void vflip_g256x8i_check()
        {
            vflip_256_check<sbyte>();
        }        

        public void vflip_g256x16i_check()
        {
            vflip_256_check<short>();
        }        

        public void vflip_g256x16u_check()
        {
            vflip_256_check<ushort>();
        }        

        public void vflip_g256x32i_check()
        {
            vflip_256_check<int>();
        }        

        public void vflip_g256x32u_check()
        {
            vflip_256_check<uint>();
        }        

        public void vflip_g256x64i_check()
        {
            
            vflip_256_check<long>();
        }

        public void vflip_g256x64u_check()
        {
            vflip_256_check<ulong>();
        }        


        void vflip_128_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)                        
            {
                var src = Random.CpuVec128<T>();
                var srcData = src.ToSpan();
                var expect  = Vec128.Load(ref mathspan.flip(srcData)[0]);
                var actual = gbits.vflip(in src);
                Claim.yea(expect.Equals(actual));
            }
        }

        void vflip_256_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)                        
            {
                var src = Random.CpuVec256<T>();
                var srcData = src.ToSpan();
                var expect  = Vec256.Load(ref mathspan.flip(srcData)[0]);
                var actual = gbits.vflip(in src);
                Claim.yea(expect.Equals(actual));
            }
        }

    }
}
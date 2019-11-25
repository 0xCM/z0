//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_rot : ScalarBitTest<t_rot>
    {

        const ulong X  = 0b0010110000111000110010101000100001000101110000110010011110110110ul;
        const ulong Y =  0b0000000000000000000000000000000000000000000000000000000011001001ul;

        const ulong Z = X & Y;        

        public void bitsub_g64u_check()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var x = Random.Next<ulong>();
                var y = (x.ToBitString()[10,20]).TakeUInt64();                
                Claim.yea(gbits.subset(y, x));                
            }
        }

        public void rotl_g8_check()
            => rotl_check<byte>();

        public void rotl_g16_check()
            => rotl_check<ushort>();


        public void rotl_g32_check()
            => rotl_check<uint>();

        public void rotl_g64_check()
            => rotl_check<ulong>();


        void rotl_check<T>()
            where T : unmanaged
        {
            var offset = Random.Next(1, bitsize<T>());
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                
                var bsx = BitString.from(x);
                var bsxRef = bsx.Replicate();
                Claim.eq(x,bsx.TakeScalar<T>());
                x = gbits.rotl(x, offset);
                bsx.RotL(offset);
                
                var y = bsx.TakeScalar<T>();
                Claim.eq(x,y);
            }
        }
    }
}
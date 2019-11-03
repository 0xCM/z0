//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class t_gather : ScalarBitTest<t_gather>
    {            
        public void gather_masks()
        {
            var m1 = BitMask32.Even;
            var x1 = Bits.gather(UInt32.MaxValue, m1);
            var y1 = Bits.scatter(x1, (uint)m1).ToBitVector();
            Claim.eq(y1,m1.ToBitVector());
            
            for(var i=0; i<y1.Length; i++)
                Claim.eq(y1[i], even(i) ? Bit.On : Bit.Off);

            var m2 = BitMask32.Lsb8;
            var x2 = Bits.gather(UInt32.MaxValue, m2);
            var y2 = Bits.scatter(x2, (uint)m2).ToBitVector();
            Claim.eq(y2,m2.ToBitVector());
            
            for(var i=0; i<y2.Length; i++)
                Claim.eq(y2[i], i % 8 == 0 ? Bit.On : Bit.Off);

        }

        public void gather_8u()
        {
            gather_check<byte>();
        }

        public void gather_16u()
        {
            gather_check<ushort>();
        }

        public void gather_32u()
        {
            gather_check<uint>();
        }


        public void gather_64u()
        {
            gather_check<ulong>();
        }
        
        void gather_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = BitRef.gather(src,mask);
                var s2 = gbits.gather(src,mask);
                Claim.eq(s1,s2);
            }
        }

    }
}
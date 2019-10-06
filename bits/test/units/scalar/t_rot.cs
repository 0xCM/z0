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
        {
            rotl_check<byte>();
        }

        public void rotl_g8_bench()
        {
            rotl_bench<byte>();
        }

        public void rotl_g16_check()
        {
            rotl_check<ushort>();
        }

        public void rotl_g16_bench()
        {
            rotl_bench<ushort>();
        }

        public void rotl_g32_check()
        {
            rotl_check<uint>();
        }

        public void rotl_32_bench()
        {
            rotl_bench<uint>();
        }

        public void rotl_g64_check()
        {
            rotl_check<ulong>();
        }

        public void rotl_g64_bench()
        {
            rotl_bench<ulong>();
        }

        public void rotr_g8_bench()
        {
            rotr_bench<byte>();
        }

        public void rotr_g16_bench()
        {
            rotr_bench<ushort>();
        }

        public void rotr_g32_bench()
        {
            rotr_bench<uint>();
        }

        public void rotr_g64_bench()
        {
            rotr_bench<ulong>();
        }

        void rotl_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(T);

            var offMin = convert<T>(2);
            var offMax = convert<T>(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.Next<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = gbits.rotl(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void rotr_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(T);

            var offMin = convert<T>(2);
            var offMax = convert<T>(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.Next<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = gbits.rotr(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void rotl_check<T>()
            where T : unmanaged
        {
            var offset = Random.Next(closed<uint>(1, bitsize<T>()));
            var offsetT = convert<uint,T>(offset);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                
                var bsx = BitString.FromScalar(in x);
                var bsxRef = bsx.Replicate();
                Claim.eq(x,bsx.TakeValue<T>());
                gbits.rotl(ref x, offsetT);
                bsx.RotL(offset);
                
                var y = bsx.TakeValue<T>();
                Claim.eq(x,y);
            }
        }
    }
}
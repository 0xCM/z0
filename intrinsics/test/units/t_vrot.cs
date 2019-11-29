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
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vrot : IntrinsicTest<t_vrot>
    {
        public void vrotrx_128x8u()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = ginx.vpunits<byte>(n128);            
                Claim.eq(ginx.vrotrx(x,8), dinx.vrotrx(x,n8));
                Claim.eq(ginx.vrotrx(x,16), dinx.vrotrx(x,n16));
                Claim.eq(ginx.vrotrx(x,24), dinx.vrotrx(x,n24));
                Claim.eq(ginx.vrotrx(x,32), dinx.vrotrx(x,n32));
            }

        }

        public void vrotlx_128x8u()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = ginx.vpunits<byte>(n128);            
                Claim.eq(ginx.vrotlx(x,8), dinx.vrotlx(x,n8));
                Claim.eq(ginx.vrotlx(x,16), dinx.vrotlx(x,n16));
                Claim.eq(ginx.vrotlx(x,24), dinx.vrotlx(x,n24));
                Claim.eq(ginx.vrotlx(x,32), dinx.vrotlx(x,n32));
            }
        }

        public void vrotl_128x8()
            => vrotl_check<byte>(n128);

        public void vrotl_128x16()
            => vrotl_check<ushort>(n128);

        public void vrotl_128x32()
            => vrotl_check<uint>(n128);

        public void vrotl_128x64()
            => vrotl_check<ulong>(n128);

        public void vrotr_128x8()
            => vrotr_check<byte>(n128);

        public void vrotr_128x16()
            => vrotr_check<ushort>(n128);

        public void vrotr_128x32()
            => vrotr_check<uint>(n128);

        public void vrotr_128x64()
            => vrotr_check<ulong>(n128);

        public void vrotl_128x8_bench()
            => vrotl_bench<byte>(n128);

        public void vrotl_128x16_bench()
            => vrotl_bench<ushort>(n128);

        public void vrotl_128x32_bench()
            => vrotl_bench<uint>(n128);

        public void vrotl_128x64_bench()
            => vrotl_bench<ulong>(n128);

        public void vrotr_128x8_bench()
            => rotr_bench<byte>(n128);

        public void vrotr_128x16_bench()
        {
            rotr_bench<ushort>(n128);
        }

        public void vrotr_128x32_bench()
        {
            rotr_bench<uint>(n128);
        }

        public void vrotr_128x64_bench()
        {
            rotr_bench<ulong>(n128);
        }

        public void vrotl_256x8()
            => vrotl_check<byte>(n256);

        public void vrotl_256x16()
            => vrotl_check<ushort>(n256);

        public void vrotl_256x32()
            => vrotl_check<uint>(n256);

        public void vrotl_256x64()
            => vrotl_check<ulong>(n256);

        public void vrotr_256x8()
            => vrotr_check<byte>(n256);

        public void vrotr_256x16()
            => vrotr_check<ushort>(n256);

        public void vrotr_256x32()
            => vrotr_check<uint>(n256);

        public void vrotr_256x64()
            => vrotr_check<ulong>(n256);

        public void vrotl_256x8_bench()
        {
            vrotl_bench<byte>(n256);
        }

        public void vrotl_256x16_bench()
        {
            vrotl_bench<ushort>(n256);
        }

        public void vrotl_256x32_bench()
        {
            vrotl_bench<uint>(n256);
        }

        public void vrotl_256x64_bench()
        {
            vrotl_bench<ulong>(n256);
        }

        public void vrotr_256x8_bench()
        {
            vrotr_bench<byte>(n256);
        }

        public void vrotr_256x16_bench()
        {
            vrotr_bench<ushort>(n256);
        }


        public void vrotr_256x32_bench()
        {
            vrotr_bench<uint>(n256);
        }


        public void vrotr_256x64_bench()
        {
            vrotr_bench<ulong>(n256);
        }

        void vrotl_check<T>(N128 n)
            where T : unmanaged
        {
            var offMin = 2;
            var offMax = bitsize<T>() - 2;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,(byte)offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotl_check<T>(N256 n)
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, (int)offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotr_check<T>(N256 n)
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, (int)offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotr_check<T>(N128 n)
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, (int)offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotl_bench<T>(N256 n)
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_{n}x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec256<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotl(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void rotr_bench<T>(N128 n)
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotr_{n}x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vector128<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotr(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void vrotr_bench<T>(N256 n)
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotr_{n}x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vector256<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotr(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void vrotl_bench<T>(N128 n)
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_{n}x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec128<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotl(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

    }

}
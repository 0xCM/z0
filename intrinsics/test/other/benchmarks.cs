//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_intrinsic_bench : t_vinx<t_intrinsic_bench>
    {
        protected override int CycleCount => Pow2.T08;

        protected override int SampleSize => Pow2.T10;


        public void bitpack_bench<T>(T t = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var composite = default(T);
            var count = counter();
            var packed = Random.Span(SampleSize,t);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                count.Start();
                var bs =  BitPack.bitspan(packed);
                for(var j=0; j < bs.Length; j+= n)
                    gmath.or(composite, BitPack.pack<T>(bs,j));
                count.Stop();
                
                Random.Fill(packed);
            }
            Benchmark($"bitspan_pack/{n}", count, packed.Length * n * CycleCount);

        }

        public void bitpack_bench()
        {
            bitpack_bench(z8);
            bitpack_bench(z16);
            bitpack_bench(z32);
            bitpack_bench(z64);
        }
        public void vrot_bench()
        {
            vrotl_bench();
            vrotr_bench();
        }

        public void vshift_bench()
        {
            vsrl_bench();
            vsll_bench();
        }

        void vrotl_bench()
        {
            vrotl_bench(n128,z8);
            vrotl_bench(n128,z16);
            vrotl_bench(n128,z32);
            vrotl_bench(n128,z64);

            vrotl_256x8_bench();
            vrotl_256x16_bench();
            vrotl_256x32_bench();
            vrotl_256x64_bench();
        }

        void vrotr_bench()
        {
            vrotr_128x8_bench();
            vrotr_128x16_bench();
            vrotr_128x32_bench();
            vrotr_128x64_bench();

            vrotr_256x8_bench();
            vrotr_256x16_bench();
            vrotr_256x32_bench();
            vrotr_256x64_bench();
        }

        void vsll_bench()
        {
            vsll_bench(n128,z8);
            vsll_bench(n128,z16);
            vsll_bench(n128,z32);
            vsll_bench(n128,z64);


            vsll_bench(n256,z8);
            vsll_bench(n256,z16);
            vsll_bench(n256,z32);
            vsll_bench(n256,z64);
        }


        void vsrl_bench()
        {
            vsrl_bench(n128,z8);
            vsrl_bench(n128,z16);
            vsrl_bench(n128,z32);
            vsrl_bench(n128,z64);


            vsrl_bench(n256,z8);
            vsrl_bench(n256,z16);
            vsrl_bench(n256,z32);
            vsrl_bench(n256,z64);
        }


        void vrotl_256x8_bench()
            => vrotl_bench<byte>(n256);

        void vrotl_256x16_bench()
            => vrotl_bench<ushort>(n256);

        void vrotl_256x32_bench()        
            => vrotl_bench<uint>(n256);
        
        void vrotl_256x64_bench()
            => vrotl_bench<ulong>(n256);

        void vrotr_128x8_bench()
            => rotr_bench<byte>(n128);

        void vrotr_128x16_bench()
            => rotr_bench<ushort>(n128);

        void vrotr_128x32_bench()
            => rotr_bench<uint>(n128);

        void vrotr_128x64_bench()
            => rotr_bench<ulong>(n128);

        void vrotr_256x8_bench()
            => vrotr_bench<byte>(n256);

        void vrotr_256x16_bench()
            => vrotr_bench<ushort>(n256);

        void vrotr_256x32_bench()
            => vrotr_bench<uint>(n256);

        void vrotr_256x64_bench()
            => vrotr_bench<ulong>(n256);


        protected void vrotl_bench<T>(N256 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var opcount = RoundCount*CycleCount;
            var last = CpuVector.zero(w,t);

            byte offMin = 2;
            byte offMax = (byte)(n - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                optime.Start();
                last = ginx.vrotl(x,offset);
                optime.Stop();
            }
            Benchmark($"rotl_{w}x{n}", optime, opcount);
        }

        protected void rotr_bench<T>(N128 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var opcount = RoundCount*CycleCount;
            var last = CpuVector.zero(w,t);

            byte offMin = 2;
            byte offMax = (byte)(n - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                optime.Start();
                last = ginx.vrotr(x,offset);
                optime.Stop();
            }
            Benchmark($"rotr_{w}x{n}", optime, opcount);
        }

        protected void vrotr_bench<T>(N256 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var opcount = RoundCount*CycleCount;
            var last = CpuVector.zero(w,t);

            byte offMin = 2;
            byte offMax = (byte)(n - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(offMin,offMax);
                optime.Start();
                last = ginx.vrotr(x,offset);
                optime.Stop();
            }
            Benchmark($"rotr_{w}x{n}", optime, opcount);
        }

        protected void vrotl_bench<T>(N128 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var opcount = RoundCount*CycleCount;
            var last = CpuVector.zero(w,t);

            byte offMin = 2;
            byte offMax = (byte)(n - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(offMin,offMax);
                optime.Start();
                last = ginx.vrotl(x,offset);
                optime.Stop();
            }
            Benchmark($"rotl_{w}x{n}", optime, opcount);
        }


        protected void vsll_bench<T>(N128 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var opcount = RoundCount * CycleCount;
            var last = CpuVector.zero(w,t);

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(n - 1));
                var x = Random.CpuVector<T>(w);
                optime.Start();
                last = ginx.vsll(x,offset);
                optime.Stop();
            
            }
            Benchmark($"sll_{w}x{n}u", optime, opcount);
        }

        protected void vsll_bench<T>(N256 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"sll_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n256);
                optime.Start();
                last = ginx.vsll(x,offset);
                optime.Stop();
            
            }
            Benchmark(opname, optime, opcount);
        }

        protected void vsrl_bench<T>(N128 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"srl_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(w);
                optime.Start();
                last = ginx.vsrl(x,offset);
                optime.Stop();
            
            }
            Benchmark(opname, optime, opcount);
        }

        protected void vsrl_bench<T>(N256 w, T t = default, SystemCounter optime = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"srl_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(w);
                optime.Start();
                last = ginx.vsrl(x,offset);
                optime.Stop();            
            }

            Benchmark(opname, optime, opcount);
        }        

    }

}

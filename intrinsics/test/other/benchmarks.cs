//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Core;
    using static vgeneric;

    public class t_intrinsic_bench : t_vinx<t_intrinsic_bench>
    {        
        protected override int CycleCount => Pow2.T08;

        protected override int RepCount => Pow2.T10;

        public override bool Enabled 
            => false;

        public void bitpack_bench()
        {
            bitpack_bench(z8);
            bitpack_bench(z16);
            bitpack_bench(z32);
            bitpack_bench(z64);
        }

        public void vand_bench()
        {
            vand_bench(w128);
            vand_bench(w256);
        }

        public void vxor_bench()
        {
            vxor_bench(w128);
            vxor_bench(w256);
        }

        public void vrotl_bench()
        {
            rotl_bench(w128);
            rotl_bench(w256);
        }

        public void vrotr_bench()
        {
            vrotr_bench(w128);
            vrotr_bench(w256);
        }

        public void vsll_bench()
        {
            vsll_bench(w128);
            vsll_bench(w256);
        }

        public void vsrl_bench()
        {         
            vsrl_bench(w128);
            vsrl_bench(w256);
        }

        public void vpop_bench()
        {
            vpop_bench_ref();
            vpop_bench(w128);
            vpop_bench(w256);
        }

        void vand_bench(W128 w)
        {
            vand_bench(w, z8);
            vand_bench(w, z16);
            vand_bench(w, z32);
            vand_bench(w, z64);
        }

        void vand_bench(W256 w)
        {
            vand_bench(w, z8);
            vand_bench(w, z16);
            vand_bench(w, z32);
            vand_bench(w, z64);
        }

        void vand_bench<T>(W128 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VSvc.vand(w,t),t);

        void vand_bench<T>(W256 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VSvc.vand(w,t),t);

        void vxor_bench(W128 w)
        {
            vxor_bench(w, z8);
            vxor_bench(w, z16);
            vxor_bench(w, z32);
            vxor_bench(w, z64);
        }

        void vxor_bench(W256 w)
        {
            vxor_bench(w, z8);
            vxor_bench(w, z16);
            vxor_bench(w, z32);
            vxor_bench(w, z64);
        }

        void vxor_bench<T>(W128 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VSvc.vxor(w,t),t);

        void vxor_bench<T>(W256 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VSvc.vxor(w,t),t);

        void rotl_bench(W128 w)
        {
            vshift_bench(w, VSvc.vrotl(w, z8), z8);
            vshift_bench(w, VSvc.vrotl(w, z16),z16);
            vshift_bench(w, VSvc.vrotl(w, z32), z32);
            vshift_bench(w, VSvc.vrotl(w, z64), z64);
        }

        void rotl_bench(W256 w)
        {
            vshift_bench(w, VSvc.vrotl(w, z8), z8);
            vshift_bench(w, VSvc.vrotl(w, z16),z16);
            vshift_bench(w, VSvc.vrotl(w, z32), z32);
            vshift_bench(w, VSvc.vrotl(w, z64), z64);
        }

        void vrotr_bench(W128 w)
        {
            vshift_bench(w, VSvc.vrotr(w, z8), z8);
            vshift_bench(w, VSvc.vrotr(w, z16),z16);
            vshift_bench(w, VSvc.vrotr(w, z32), z32);
            vshift_bench(w, VSvc.vrotr(w, z64), z64);
        }

        void vrotr_bench(W256 w)
        {
            vshift_bench(w, VSvc.vrotr(w, z8), z8);
            vshift_bench(w, VSvc.vrotr(w, z16),z16);
            vshift_bench(w, VSvc.vrotr(w, z32), z32);
            vshift_bench(w, VSvc.vrotr(w, z64), z64);
        }

        void vsll_bench(W128 w)
        {
            vshift_bench(w,VSvc.vsll(w, z8), z8);
            vshift_bench(w,VSvc.vsll(w, z16), z16);
            vshift_bench(w,VSvc.vsll(w, z32), z32);
            vshift_bench(w,VSvc.vsll(w, z64), z64);            
        }

        void vsll_bench(N256 w)
        {

            vshift_bench(w,VSvc.vsll(w, z8), z8);
            vshift_bench(w,VSvc.vsll(w, z16), z16);
            vshift_bench(w,VSvc.vsll(w, z32), z32);
            vshift_bench(w,VSvc.vsll(w, z64), z64);            
        }

        void vsrl_bench(N256 w)
        {
            vshift_bench(w,VSvc.vsrl(w, z8), z8);
            vshift_bench(w,VSvc.vsrl(w, z16), z16);
            vshift_bench(w,VSvc.vsrl(w, z32), z32);
            vshift_bench(w,VSvc.vsrl(w, z64), z64);            
        }

        void vsrl_bench(W128 w)
        {
            vshift_bench(w,VSvc.vsrl(w, z8), z8);
            vshift_bench(w,VSvc.vsrl(w, z16), z16);
            vshift_bench(w,VSvc.vsrl(w, z32), z32);
            vshift_bench(w,VSvc.vsrl(w, z64), z64);            
        }

        void vbinop_bench<F,T>(N128 w, F f, T t = default, SystemCounter clock = default)
            where F : ISVBinaryOp128Api<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = (int)NatCalc.divT(w,t);
            var blockcount = RepCount/blocklen;
            var bitlen = bitsize(t);
            var ops = 0;

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var lData = Random.Blocks<T>(w,blockcount);
                var rData = Random.Blocks<T>(w,blockcount);

                clock.Start();
                for(var block=0; block<blockcount; block++, ops++)
                    last = f.Invoke(lData.LoadVector(block), rData.LoadVector(block));  
                clock.Stop();
            }

            ReportBenchmark(f.Id, ops, clock);
        }

        void vbinop_bench<F,T>(N256 w, F f, T t = default, SystemCounter clock = default)
            where F : ISVBinaryOp256Api<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = (int)NatCalc.divT(w,t);
            var blockcount = RepCount/blocklen;
            var bitlen = bitsize(t);
            var ops = 0;

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var lData = Random.Blocks<T>(w,blockcount);
                var rData = Random.Blocks<T>(w,blockcount);

                clock.Start();
                for(var block=0; block<blockcount; block++, ops++)
                    last = f.Invoke(lData.LoadVector(block), rData.LoadVector(block));  
                clock.Stop();
            }

            ReportBenchmark(f.Id, ops, clock);
        }

        void vshift_bench<F,T>(N128 w, F f, T t = default, SystemCounter clock = default)
            where F : ISVImm8UnaryOp128Api<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = (int)NatCalc.divT(w,t);
            var blockcount = RepCount/blocklen;
            var bitlen = bitsize(t);
            var ops = 0;

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var data = Random.Blocks<T>(w,blockcount);

                clock.Start();
                for(var block=0; block<blockcount; block++, ops++)
                    last = f.Invoke(data.LoadVector(block),offset);  
                clock.Stop();
            }
            
            ReportBenchmark(f.Id,  ops, clock);
        }

        void vshift_bench<F,T>(N256 w, F f, T t = default, SystemCounter clock = default)
            where F : ISVImm8UnaryOp256Api<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = (int)NatCalc.divT(w,t);
            var blockcount = RepCount/blocklen;
            var bitlen = bitsize(t);
            var ops = 0;

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var data = Random.Blocks<T>(w,blockcount);

                clock.Start();
                for(var block=0; block<blockcount; block++, ops++)
                    last = f.Invoke(data.LoadVector(block),offset);  
                clock.Stop();
            }
            
            ReportBenchmark(f.Id,  ops, clock);
        }

        public void bitspan_scalar32_bench()
        {
            var clock = counter();
            var last = 0u;
            var ops = 0;

            for(var cycle = 0; cycle < Pow2.T12; cycle++)
            {
                var data = Random.BitSpan(Pow2.T10);
                clock.Start();
                for(var i=0; i<data.Length; i+= 32, ops++)
                    last = BitSpan.extract<uint>(data, i);
                clock.Stop();
            }
            
            ReportBenchmark("bitspan_scalar/32", ops, clock);
        }

        void bitpack_bench<T>(T t = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var ops = 0;
            var composite = default(T);
            var clock = counter();
            var packed = Random.Span(RepCount,t);

            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                clock.Start();
                var bs =  BitSpan.load(packed);
                for(var j=0; j < bs.Length; j+= n, ops++)
                    gmath.or(composite, BitSpan.extract<T>(bs,j));
                clock.Stop();
                
                Random.SpanFill(packed);
            }
            
            ReportBenchmark($"bitspan_pack/{n}", ops, clock);
        }


        void vpop_bench(N256 n, SystemCounter counter = default)
        {            
            var total = 0ul;
            var opcount = 0;
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);
                var z = Random.CpuVector<ulong>(n);
                counter.Start();
                for(var i=0; i<RepCount; i++)
                    total += dvec.vpop(x,y,z);
                counter.Stop();
                opcount += (4 * 3 * RepCount);
            }
            ReportBenchmark($"vpop_3x256", opcount,counter);
        }

        void vpop_bench(W128 n, SystemCounter counter = default)
        {            
            var total = 0ul;
            var opcount = 0;
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);
                var z = Random.CpuVector<ulong>(n);
                counter.Start();
                for(var i=0; i<RepCount; i++)
                    total += dvec.vpop(x,y,z);
                counter.Stop();
                opcount += (2 * 3 * RepCount);
            }
            ReportBenchmark($"vpop_3x128", opcount,counter);
        }

        void vpop_bench_ref(SystemCounter counter = default)
        {            
            var total = 0u;
            var opcount = 0;
            Span<ulong> samples = stackalloc ulong[RepCount];
            ref readonly var src = ref head(samples);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                Random.Fill(RepCount, ref head(samples));
                counter.Start();
                for(var i=0; i< RepCount; i++)
                    total += Bits.pop(skip(in head(samples), i));
                counter.Stop();
                opcount += RepCount;
            }
            ReportBenchmark($"vpop_1x64_ref", opcount, counter);
        }
    }
}

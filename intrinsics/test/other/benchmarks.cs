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

        protected override int SampleCount => Pow2.T10;


        public void benchmarks()
        {
            bitpack_bench();
            vsrl_bench_run();
            vsll_bench_run();
            vrotl_bench_run();
            vrotr_bench_run();
            vxor_bench_run();
            vand_bench_run();
        }

        void bitpack_bench()
        {
            bitpack_bench(z8);
            bitpack_bench(z16);
            bitpack_bench(z32);
            bitpack_bench(z64);
        }
        
        void vxor_bench_run()
        {
            void bench_128(N128 w)
            {
                vbinop_bench(w,VX.vxor(w, z8), z8);
                vbinop_bench(w,VX.vxor(w, z16), z16);
                vbinop_bench(w,VX.vxor(w, z32), z32);
                vbinop_bench(w,VX.vxor(w, z64), z64);            
            }

            void bench_256(N256 w)
            {
                vbinop_bench(w,VX.vxor(w, z8), z8);
                vbinop_bench(w,VX.vxor(w, z16), z16);
                vbinop_bench(w,VX.vxor(w, z32), z32);
                vbinop_bench(w,VX.vxor(w, z64), z64);            
            }

            bench_128(n128);
            bench_256(n256);
        }

        void vand_bench_run()
        {
            void bench_128(N128 w)
            {
                vbinop_bench(w,VX.vand(w, z8), z8);
                vbinop_bench(w,VX.vand(w, z16), z16);
                vbinop_bench(w,VX.vand(w, z32), z32);
                vbinop_bench(w,VX.vand(w, z64), z64);            
            }

            void bench_256(N256 w)
            {
                vbinop_bench(w,VX.vand(w, z8), z8);
                vbinop_bench(w,VX.vand(w, z16), z16);
                vbinop_bench(w,VX.vand(w, z32), z32);
                vbinop_bench(w,VX.vand(w, z64), z64);            
            }

            bench_128(n128);
            bench_256(n256);
        }

        void vrotl_bench_run()
        {
            void bench_128(N128 w)
            {
                vshift_bench(w, VX.vrotl(w, z8), z8);
                vshift_bench(w, VX.vrotl(w, z16),z16);
                vshift_bench(w, VX.vrotl(w, z32), z32);
                vshift_bench(w, VX.vrotl(w, z64), z64);
            }

            void bench_256(N256 w)
            {
                vshift_bench(w, VX.vrotl(w, z8), z8);
                vshift_bench(w, VX.vrotl(w, z16),z16);
                vshift_bench(w, VX.vrotl(w, z32), z32);
                vshift_bench(w, VX.vrotl(w, z64), z64);
            }

            bench_128(n128);
            bench_256(n256);
        }

        void vrotr_bench_run()
        {
            void bench_128(N128 w)
            {
                vshift_bench(w, VX.vrotr(w, z8), z8);
                vshift_bench(w, VX.vrotr(w, z16),z16);
                vshift_bench(w, VX.vrotr(w, z32), z32);
                vshift_bench(w, VX.vrotr(w, z64), z64);
            }

            void bench_256(N256 w)
            {
                vshift_bench(w, VX.vrotr(w, z8), z8);
                vshift_bench(w, VX.vrotr(w, z16),z16);
                vshift_bench(w, VX.vrotr(w, z32), z32);
                vshift_bench(w, VX.vrotr(w, z64), z64);
            }

            bench_128(n128);
            bench_256(n256);
        }

        void vsll_bench_run()
        {
            void bench_128(N128 w)
            {
                vshift_bench(w,VX.vsll(w, z8), z8);
                vshift_bench(w,VX.vsll(w, z16), z16);
                vshift_bench(w,VX.vsll(w, z32), z32);
                vshift_bench(w,VX.vsll(w, z64), z64);            

            }

            void bench_256(N256 w)
            {

                vshift_bench(w,VX.vsll(w, z8), z8);
                vshift_bench(w,VX.vsll(w, z16), z16);
                vshift_bench(w,VX.vsll(w, z32), z32);
                vshift_bench(w,VX.vsll(w, z64), z64);            
            }

            bench_128(n128);
            bench_256(n256);
        }

        void vsrl_bench_run()
        {
            void bench_256(N256 w)
            {
                vshift_bench(w,VX.vsrl(w, z8), z8);
                vshift_bench(w,VX.vsrl(w, z16), z16);
                vshift_bench(w,VX.vsrl(w, z32), z32);
                vshift_bench(w,VX.vsrl(w, z64), z64);            

            }

            void bench_128(N128 w)
            {
                vshift_bench(w,VX.vsrl(w, z8), z8);
                vshift_bench(w,VX.vsrl(w, z16), z16);
                vshift_bench(w,VX.vsrl(w, z32), z32);
                vshift_bench(w,VX.vsrl(w, z64), z64);            
            }
         
            bench_128(n128);
            bench_256(n256);
        }

        protected void vbinop_bench<F,T>(N128 w, F f, T t = default, SystemCounter optime = default)
            where F : IVBinOp<Vector128<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
            var blockcount = SampleCount/blocklen;
            var bitlen = bitsize(t);
            var opcount = 0;

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var lData = Random.Blocks<T>(w,blockcount);
                var rData = Random.Blocks<T>(w,blockcount);

                optime.Start();
                for(var block=0; block<blockcount; block++)
                    last = f.Invoke(lData.LoadVector(block), rData.LoadVector(block));  
                optime.Stop();
            }
            ReportBenchmark(f.Moniker,  CycleCount*SampleCount*TypeMath.div(w,t), optime);

        }

        protected void vbinop_bench<F,T>(N256 w, F f, T t = default, SystemCounter optime = default)
            where F : IVBinOp<Vector256<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
            var blockcount = SampleCount/blocklen;
            var bitlen = bitsize(t);

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var lData = Random.Blocks<T>(w,blockcount);
                var rData = Random.Blocks<T>(w,blockcount);

                optime.Start();
                for(var block=0; block<blockcount; block++)
                    last = f.Invoke(lData.LoadVector(block), rData.LoadVector(block));  
                optime.Stop();
            }
            ReportBenchmark(f.Moniker,  CycleCount*SampleCount*TypeMath.div(w,t), optime);

        }

        protected void vshift_bench<F,T>(N128 w, F f, T t = default, SystemCounter optime = default)
            where F : IVShiftOp<Vector128<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
            var blockcount = SampleCount/blocklen;
            var bitlen = bitsize(t);

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var data = Random.Blocks<T>(w,blockcount);

                optime.Start();
                for(var block=0; block<blockcount; block++)
                    last = f.Invoke(data.LoadVector(block),offset);  
                optime.Stop();
            }
            ReportBenchmark(f.Moniker,  CycleCount*SampleCount*TypeMath.div(w,t), optime);

        }

        protected void vshift_bench<F,T>(N256 w, F f, T t = default, SystemCounter optime = default)
            where F : IVShiftOp<Vector256<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
            var blockcount = SampleCount/blocklen;
            var bitlen = bitsize(t);

            for(var cycle = 0; cycle < CycleCount; cycle++)  
            { 
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var data = Random.Blocks<T>(w,blockcount);

                optime.Start();
                for(var block=0; block<blockcount; block++)
                    last = f.Invoke(data.LoadVector(block),offset);  
                optime.Stop();
            }
            ReportBenchmark(f.Moniker,  CycleCount*SampleCount*TypeMath.div(w,t), optime);

        }


        void vxor_ginx_bench<T>(N256 w, T t = default,  SystemCounter counter = default)
            where T : unmanaged
        {
            var blocks = SampleCount/size<T>();
            var blocklen = DataBlocks.blocklen(w,t);
            var xb = Random.Blocks<T>(w,blocks);
            var yb = Random.Blocks<T>(w,blocks);
            var zb = DataBlocks.alloc<T>(w,blocks);

            counter.Start();
            for(var i=0; i<CycleCount; i++)
                ginx.vxor(xb, yb, zb);
            counter.Stop();

            ReportBenchmark(moniker("vxor_blocked",w,t), CycleCount*SampleCount*TypeMath.div(w,t), counter);
        }


        public void bitpack_bench<T>(T t = default)
            where T : unmanaged
        {
            var n = bitsize(t);
            var composite = default(T);
            var count = counter();
            var packed = Random.Span(SampleCount,t);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                count.Start();
                var bs =  BitPack.bitspan(packed);
                for(var j=0; j < bs.Length; j+= n)
                    gmath.or(composite, BitPack.pack<T>(bs,j));
                count.Stop();
                
                Random.Fill(packed);
            }
            ReportBenchmark($"bitspan_pack/{n}", packed.Length * n * CycleCount, count);

        }

    }

}

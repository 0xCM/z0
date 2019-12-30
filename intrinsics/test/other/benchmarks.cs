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

        protected override int RepCount => Pow2.T10;

        public void bitpack_bench()
        {
            bitpack_bench(z8);
            bitpack_bench(z16);
            bitpack_bench(z32);
            bitpack_bench(z64);
        }

        public void vand_bench()
        {
            vand_bench(n128);
            vand_bench(n256);
        }

        void vand_bench(N128 w)
        {
            vand_bench(w, z8);
            vand_bench(w, z16);
            vand_bench(w, z32);
            vand_bench(w, z64);
        }

        void vand_bench(N256 w)
        {
            vand_bench(w, z8);
            vand_bench(w, z16);
            vand_bench(w, z32);
            vand_bench(w, z64);
        }

        void vand_bench<T>(N128 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VX.vand(w,t),t);

        void vand_bench<T>(N256 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VX.vand(w,t),t);

        public void vxor_bench()
        {
            vxor_bench(n128);
            vxor_bench(n256);
        }

        void vxor_bench(N128 w)
        {
            vxor_bench(w, z8);
            vxor_bench(w, z16);
            vxor_bench(w, z32);
            vxor_bench(w, z64);
        }

        void vxor_bench(N256 w)
        {
            vxor_bench(w, z8);
            vxor_bench(w, z16);
            vxor_bench(w, z32);
            vxor_bench(w, z64);
        }

        void vxor_bench<T>(N128 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VX.vxor(w,t),t);

        void vxor_bench<T>(N256 w, T t)
            where T : unmanaged
                => vbinop_bench(w, VX.vxor(w,t),t);

        public void vrotl_bench()
        {
            rotl_bench(n128);
            rotl_bench(n256);
        }

        void rotl_bench(N128 w)
        {
            vshift_bench(w, VX.vrotl(w, z8), z8);
            vshift_bench(w, VX.vrotl(w, z16),z16);
            vshift_bench(w, VX.vrotl(w, z32), z32);
            vshift_bench(w, VX.vrotl(w, z64), z64);
        }

        void rotl_bench(N256 w)
        {
            vshift_bench(w, VX.vrotl(w, z8), z8);
            vshift_bench(w, VX.vrotl(w, z16),z16);
            vshift_bench(w, VX.vrotl(w, z32), z32);
            vshift_bench(w, VX.vrotl(w, z64), z64);
        }

        public void vrotr_bench()
        {
            vrotr_bench(n128);
            vrotr_bench(n256);
        }

        void vrotr_bench(N128 w)
        {
            vshift_bench(w, VX.vrotr(w, z8), z8);
            vshift_bench(w, VX.vrotr(w, z16),z16);
            vshift_bench(w, VX.vrotr(w, z32), z32);
            vshift_bench(w, VX.vrotr(w, z64), z64);
        }

        void vrotr_bench(N256 w)
        {
            vshift_bench(w, VX.vrotr(w, z8), z8);
            vshift_bench(w, VX.vrotr(w, z16),z16);
            vshift_bench(w, VX.vrotr(w, z32), z32);
            vshift_bench(w, VX.vrotr(w, z64), z64);
        }


        void vsll_bench()
        {

            vsll_bench(n128);
            vsll_bench(n256);
        }

        void vsll_bench(N128 w)
        {
            vshift_bench(w,VX.vsll(w, z8), z8);
            vshift_bench(w,VX.vsll(w, z16), z16);
            vshift_bench(w,VX.vsll(w, z32), z32);
            vshift_bench(w,VX.vsll(w, z64), z64);            

        }

        void vsll_bench(N256 w)
        {

            vshift_bench(w,VX.vsll(w, z8), z8);
            vshift_bench(w,VX.vsll(w, z16), z16);
            vshift_bench(w,VX.vsll(w, z32), z32);
            vshift_bench(w,VX.vsll(w, z64), z64);            
        }

        public void vsrl_bench()
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

        protected void vbinop_bench<F,T>(N128 w, F f, T t = default, SystemCounter clock = default)
            where F : IVBinOp128<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
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

            ReportBenchmark(f.Moniker, ops, clock);
        }

        protected void vbinop_bench<F,T>(N256 w, F f, T t = default, SystemCounter clock = default)
            where F : IVBinOp256<T>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
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

            ReportBenchmark(f.Moniker, ops, clock);
        }

        protected void vshift_bench<F,T>(N128 w, F f, T t = default, SystemCounter clock = default)
            where F : IVShiftOp<Vector128<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
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
            
            ReportBenchmark(f.Moniker,  ops, clock);
        }

        protected void vshift_bench<F,T>(N256 w, F f, T t = default, SystemCounter clock = default)
            where F : IVShiftOp<Vector256<T>>
            where T : unmanaged
        {
            var last = vzero(w,t);
            var blocklen = TypeMath.div(w,t);
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
            
            ReportBenchmark(f.Moniker,  ops, clock);
        }

        public void bitspan_to_scalar32_bench()
        {
            var clock = counter();
            var last = 0u;
            var ops = 0;

            for(var cycle = 0; cycle < Pow2.T12; cycle++)
            {
                var data = Random.BitSpan(Pow2.T10);
                clock.Start();
                for(var i=0; i<data.Length; i+= 32, ops++)
                    last = data.Scalar<uint>(i,32);
                clock.Stop();
            }
            
            ReportBenchmark("bitspan_scalar/32", ops, clock);
        }

        public void bitpack_bench<T>(T t = default)
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
                var bs =  BitPack.bitspan(packed);
                for(var j=0; j < bs.Length; j+= n, ops++)
                    gmath.or(composite, BitPack.pack<T>(bs,j));
                clock.Stop();
                
                Random.Fill(packed);
            }
            
            ReportBenchmark($"bitspan_pack/{n}", ops, clock);
        }

    }

}

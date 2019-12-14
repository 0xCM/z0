//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using VecLen = NatSeq<N1,N2,N3>;
    
    using static zfunc;

    public class vblock_sub : UnitTest<vblock_sub>
    {   
        public void vblock_sub_123x8i()
        {
            vblock_sub_check<VecLen,sbyte>();
        }

        public void vblock_sub_123x8i_bench()
        {
            vblock_sub_bench<VecLen,sbyte>();
        }

        public void vblock_sub_123x8()
        {
            vblock_sub_check<VecLen,byte>();
        }

        public void vblock_sub_123x8_bench()
        {
            vblock_sub_bench<VecLen,byte>();
        }

        public void vblock_sub_123x16i()
        {
            vblock_sub_check<VecLen,short>();
        }

        public void vblock_sub_123x16i_bench()
        {
            vblock_sub_bench<VecLen,short>();
        }

        public void vblock_sub_123x16()
        {
            vblock_sub_check<VecLen,ushort>();
        }

        public void vblock_sub_123x16_bench()
        {
            vblock_sub_bench<VecLen,ushort>();
        }

        public void vblock_sub_123x32i()
        {
            vblock_sub_check<VecLen,int>();
        }

        public void vblock_sub_123x32i_bench()
        {
            vblock_sub_bench<VecLen,int>();
        }

        public void vblock_sub_123x32()
        {
            vblock_sub_check<VecLen,uint>();
        }

        public void vblock_sub_123x32_bench()
        {
            vblock_sub_bench<VecLen,uint>();
        }

        public void vblock_sub_123x64i()
        {
            vblock_sub_check<VecLen,long>();
        }

        public void vblock_sub_123x64i_bench()
        {
            vblock_sub_bench<VecLen,long>();
        }

        public void vblock_sub_123x64()
        {
            vblock_sub_check<VecLen,ulong>();
        }

        public void vblock_sub_123x64_bench()
        {
            vblock_sub_bench<VecLen,ulong>();
        }

        public void vblock_sub_123x32f()
        {
            vblock_sub_check<VecLen,float>();
        }

        public void vblock_sub_123x32f_bench()
        {
            vblock_sub_bench<VecLen,float>();
        }

        public void vblock_sub_123x64f()
        {
            vblock_sub_check<VecLen,double>();
        }

        public void vblock_sub_123x64f_bench()
        {
            vblock_sub_bench<VecLen,double>();
        }

        void vblock_sub_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var n = new N();
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i< SampleSize; i++)            
            {
                var v1 = Random.VectorBlock<N,T>();
                var v2 = Random.VectorBlock<N,T>();
                var v3 = RowVector.blockload(mathspan.sub(v1.Unsized,v2.Unsized), n);                
                Linear.sub(v1, v2, ref v1);
                Claim.yea(v3 == v1);
            } 
        }

        void vblock_sub_bench<N,T>(N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var opcount = CycleCount*RoundCount;
            var sw = stopwatch(false);
            var opname = $"vblock_sub_{n}x{bitsize<T>()}";
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i<opcount; i++)
            {
                var v1 = Random.VectorBlock<N,T>();
                var v2 = Random.VectorBlock<N,T>();
                sw.Start();
                Linear.sub(v1, v2, ref v1);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

    }


}
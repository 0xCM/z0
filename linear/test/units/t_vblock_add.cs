//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using VecLen = NatSeq<N1,N2,N3>;
    
    using static zfunc;

    public class t_vblock_add : UnitTest<t_vblock_add>
    {   
        public void vblock_add_123x8i()
            => vblock_add_check<VecLen,sbyte>();

        public void vblock_add_123x8()
            => vblock_add_check<VecLen,byte>();

        public void vblock_add_123x16i()
            => vblock_add_check<VecLen,short>();

        public void vblock_add_123x16()
            => vblock_add_check<VecLen,ushort>();

        public void vblock_add_123x32i()
            => vblock_add_check<VecLen,int>();

        public void vblock_add_123x16i_bench()
            => vblock_add_bench<VecLen,short>();

        public void vblock_add_123x16_bench()
            => vblock_add_bench<VecLen,ushort>();

        public void vblock_add_123x8i_bench()
            => vblock_add_bench<VecLen,sbyte>();

        public void vblock_add_123x8_bench()
            => vblock_add_bench<VecLen,byte>();
        
        public void vblock_add_123x32i_bench()
            => vblock_add_bench<VecLen,int>();

        public void vblock_add_123x32()
        {
            vblock_add_check<VecLen,uint>();
        }

        public void vblock_add_123x32_bench()
        {
            vblock_add_bench<VecLen,uint>();
        }

        public void vblock_add_123x64i()
        {
            vblock_add_check<VecLen,long>();
        }

        public void vblock_add_123x64i_bench()
            => vblock_add_bench<VecLen,long>();
 
        public void vblock_add_123x64()
            => vblock_add_check<VecLen,ulong>();

        public void vblock_add_123x64_bench()
        {
            vblock_add_bench<VecLen,ulong>();
        }

        public void vblock_add_123x32f()
        {
            vblock_add_check<VecLen,float>();
        }

        public void vblock_add_123x32f_bench()
        {
            vblock_add_bench<VecLen,float>();
        }

        public void vblock_add_123x64f()
        {
            vblock_add_check<VecLen,double>();
        }

        public void vblock_add_123x64f_bench()
        {
            vblock_add_bench<VecLen,double>();
        }

        void vblock_add_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var n = new N();
            var v4 = Vector.blockalloc<N,T>();
            for(var i=0; i< CycleCount; i++)            
            {
                var v1 = Random.VectorBlock<N,T>();
                var v2 = Random.VectorBlock<N,T>();
                var v3 = Vector.blockload(mathspan.add(v1.Unsized,v2.Unsized), n);
                Linear.add(ref v1, v2);
                Claim.yea(v3 == v1);
            }
        }

        void vblock_add_bench<N,T>(N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var opcount = CycleCount*RoundCount;
            var sw = stopwatch(false);
            var opname = $"vblock_add_{n}x{bitsize<T>()}";
            var dst = Vector.blockalloc<N,T>();
            for(var i=0; i<opcount; i++)
            {
                var v1 = Random.VectorBlock<N,T>();
                var v2 = Random.VectorBlock<N,T>();
                sw.Start();
                Linear.add(ref v1, v2);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }
    }

}
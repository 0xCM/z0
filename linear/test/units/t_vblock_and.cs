//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using VecLen = N64;

    public class t_vblock_and : UnitTest<t_vblock_and>
    {
        public void vblock_and()
        {
            vblock_and_check<VecLen,byte>();
            vblock_and_check<VecLen,sbyte>();
            vblock_and_check<VecLen,short>();
            vblock_and_check<VecLen,ushort>();
            vblock_and_check<VecLen,int>();
            vblock_and_check<VecLen,uint>();
            vblock_and_check<VecLen,long>();
            vblock_and_check<VecLen,ulong>();
            
        }

        void vblock_and_check<N,T>()
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var rep = new N();
            var len = (int)rep.NatValue;
            var u = Random.VectorBlock<N,T>();
            var v = Random.VectorBlock<N,T>();
            var vResult = Linear.and(u, v);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gmath.and(u[i], v[i]);
            var vExpect = Vector.blockload(calcs, rep);            
            
            Claim.eq(vExpect.Data, vResult.Data);
        }

    }

}
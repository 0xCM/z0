//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static Nats;

    public class t_vblock_and : UnitTest<t_vblock_and>
    {
        public void vblock_and_n64x8u()
            => vblock_and_check(n64, z8);

        public void vblock_and_n64x8i()
            => vblock_and_check(n64, z8i);

        public void vblock_and_n64x16i()
            => vblock_and_check(n64, z16i);

        public void vblock_and_n64x16u()
            => vblock_and_check(n64, z16);

        public void vblock_and_n64x32i()
            => vblock_and_check(n64, z32i);

        public void vblock_and_n64x32u()
            => vblock_and_check(n64, z32);

        public void vblock_and_n64x64i()
            => vblock_and_check(n64, z64i);

        public void vblock_and_n64x64u()
            => vblock_and_check(n64, z64);

        static Block256<T> and<T>(Block256<T> lhs, Block256<T> rhs)
            where T : unmanaged
        {
            var dst = Blocks.alloc<T>(n256,lhs.BlockCount);
            gspan.and(lhs,rhs, dst.Data);
            return dst;
        }            

        protected void vblock_and_check<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var length = natval(n);
            var u = Random.VectorBlock(n,t);
            var v = Random.VectorBlock(n,t);
            var result = Linear.and(u, v);            
            var expect = and(u.Data, v.Data);
            
            Claim.numeq(expect.Data, result.Data);
        }

    }

}
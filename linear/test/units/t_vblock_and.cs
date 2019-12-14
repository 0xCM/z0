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

        protected void vblock_and_check<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var length = natval(n);
            var u = Random.VectorBlock(n,t);
            var v = Random.VectorBlock(n,t);
            var result = Linear.and(u, v);            
            var expect = mathspan.and(u.Data, v.Data);
            
            Claim.eq(expect.Data, result.Data);
        }

    }

}
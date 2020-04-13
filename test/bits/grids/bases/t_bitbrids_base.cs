//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public abstract class t_bitgrids_base<U> : UnitTest<U>
        where U : t_bitgrids_base<U>, new()
    {          
        /// <summary>
        /// Asserts logical bitvector/bitstring equality
        /// </summary>
        /// <param name="bv">The bitvector to compare</param>
        /// <param name="bs">The bitstring to compare</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="S">The vector cell type</typeparam>
        protected void ClaimEqual<N,S>(BitBlock<N,S> bv, BitString bs)
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {
            var n = (int)(new N().NatValue);
            Claim.eq(bs.Length, n);
            for(var i=0; i<n; i++)
                Claim.eq(bv[i], bs[i]);
        }

        protected static NatSeq<N2,N1,N7> n217 => default;

        protected static NatSeq<N2,N1,N3> n213 = default;
    }
}
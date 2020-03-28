//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static Root;

    public abstract class t_bitgrids_base<U> : UnitTest<U>
        where U : t_bitgrids_base<U>, new()
    {     
        static Span<T> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
            where F : ISBinaryOpApi<T>
        {        
            var count = lhs.Length;
            var dst = alloc<T>(count);
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }

        static Span<T> apply<F,T>(F f, Span<T> lhs, Span<T> rhs)
            where T : unmanaged
            where F : ISBinaryOpApi<T>
                => apply(f,lhs.ReadOnly(), rhs.ReadOnly());
     
        protected static Span<T> and<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => apply(MathServices.and<T>(),lhs,rhs);

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
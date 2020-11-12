//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public class RngSuite256<N> : IRngSuite256<N>
        where N : unmanaged, ITypeNat
    {
        readonly IPolyrand[] members;

        static readonly int n = (int)new N().NatValue;

        public RngSuite256(IPolyrand[] members)
        {
            this.members = members.ToArray();
            require(this.members.Length == n);
        }

        public RngSuite256(IEnumerable<IPolyrand> members)
        {
            this.members = members.ToArray();
            require(this.members.Length == n);
        }

        public Block256<N,T> Next<T>()
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>();
            return dst;
        }

        public Block256<N,T> Next<T>(T min)
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min);
            return dst;
        }

        public Block256<N, T> Next<T>(T min, T max)
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min,max);
            return dst;
        }

        public Block256<N, T> Next<T>(Interval<T> domain)
             where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(domain);
            return dst;
        }

        public IPolyrand Select(int index)
            => members[index];
    }
}
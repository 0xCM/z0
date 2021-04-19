//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public class PolyBlocks256<N> : IPolyBlocks256<N>
        where N : unmanaged, ITypeNat
    {
        readonly IPolySource[] members;

        static int n => (int)new N().NatValue;

        public PolyBlocks256(IPolySource[] members)
        {
            this.members = members.ToArray();
            root.require(this.members.Length == n, () => $"Equality of {n} there is not");
        }

        public PolyBlocks256(IEnumerable<IPolySource> members)
        {
            this.members = members.ToArray();
            root.require(this.members.Length == n, () => $"Equality of {n} there is not");
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

        public Block256<N,T> Next<T>(T min, T max)
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min,max);
            return dst;
        }

        public Block256<N,T> Next<T>(Interval<T> domain)
             where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(domain);
            return dst;
        }

        public IPolySource Select(int index)
            => skip(members,index);
    }
}